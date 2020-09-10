using System;
using System.Collections.Generic;
using AlgorithmInterviewButler.Models;
using AlgorithmInterviewButler.Services;

namespace AlgorithmInterviewButler.ViewModels{
  public class RandomPickBoxViewModel {

    public InterviewProblem GetRandomProblem(){
      List<int> keys = InterviewProblemsDB.GetKeys();
      Random rand = new Random();
      while(true){
        int idx = rand.Next(keys.Count);
        int key = keys[idx];
        return InterviewProblemsDB.GetProblem(key);
      }
    }
  }
}