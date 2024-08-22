/********************************************************************************
** Form generated from reading UI file 'Sterowanie.ui'
**
** Created by: Qt User Interface Compiler version 6.7.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_STEROWANIE_H
#define UI_STEROWANIE_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_Sterowanie
{
public:

    void setupUi(QWidget *Sterowanie)
    {
        if (Sterowanie->objectName().isEmpty())
            Sterowanie->setObjectName("Sterowanie");
        Sterowanie->resize(400, 300);

        retranslateUi(Sterowanie);

        QMetaObject::connectSlotsByName(Sterowanie);
    } // setupUi

    void retranslateUi(QWidget *Sterowanie)
    {
        Sterowanie->setWindowTitle(QCoreApplication::translate("Sterowanie", "Sterowanie", nullptr));
    } // retranslateUi

};

namespace Ui {
    class Sterowanie: public Ui_Sterowanie {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_STEROWANIE_H
