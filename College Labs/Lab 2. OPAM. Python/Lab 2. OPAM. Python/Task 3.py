R1 = float(input("������ ��� ����� �����: "));
R2 = float(input("������ ��� ����� �����: "));

print("�� ��'����� �����?");
print("1. ����������");
print("2. ���������");
choice = input("��� ����: ");

if choice == '1':
    R = (R1 * R2) / (R1 + R2);
    print("��� �����: ", R);
elif choice == '2':
    R = R1 + R2;
    print("��� �����: ", R);
else:
    print("������� ����");
