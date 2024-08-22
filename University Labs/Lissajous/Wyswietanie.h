#ifndef LISSAJOUS_WYSWIETANIE_H
#define LISSAJOUS_WYSWIETANIE_H


#include "Model.h"
#include <QPointF>
#include <QPolygonF>
#include <QGraphicsPolygonItem>
#include <QGraphicsScene>
#include <QGraphicsView>

class Wyswietlanie : public QGraphicsView {
    Q_OBJECT
private:
    Model *model;

    QPolygonF *poligon;
    QGraphicsPolygonItem *polItem;
    QGraphicsScene *scene;
public:
    Wyswietlanie(QWidget *parent = nullptr);
    ~Wyswietlanie();

    void podlaczModel(Model *_model) { model = _model; }
    void show();
public
    slots:
    void przerysuj(int a);
};


#endif
