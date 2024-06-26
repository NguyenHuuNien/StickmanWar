using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class QueueEnemy{
    private static QueueEnemy instance;
    public static QueueEnemy Instance{
        get{
            if(instance == null){
                instance = new QueueEnemy();
            }
            return instance;
        }
    }
    private Queue<Enemy> enemyQueue = new Queue<Enemy>();
    public void addEnemy(Enemy enemy){
        enemy.gameObject.SetActive(false);
        enemyQueue.Enqueue(enemy);
    }
    public Enemy getEnemy(){
        if(enemyQueue.Count > 0){
            return enemyQueue.Dequeue();
        }else{
            return null;
        }
    }
}