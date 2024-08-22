#ifndef LISSAJOUS_STEROWANIE_H
#define LISSAJOUS_STEROWANIE_H

#include <QWidget>
#include <QPushButton>
#include <QSlider>
#include <QLabel>
#include <QVBoxLayout>

class Sterowanie : public QWidget {
    Q_OBJECT
private:
    QLabel *napis_a;
    QSlider *slider_a;
    QPushButton *przyciskKoniec;
    QVBoxLayout *ukladacz;
public:
    Sterowanie(QWidget *parent = nullptr);

    const QPushButton *przycisk() { return przyciskKoniec; }
    const QSlider *slidera() { return slider_a; }
};


#endif
