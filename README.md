# Demo of Flattened Abstract Syntax Trees in Deep Learning using GitPod (see also the Visual Studio Code Extension)

This repository provides a demonstration of the deep learning package for classifying code parsed by the [fast
utility](https://cloud.docker.com/u/yijun/repository/docker/yijun/fast). You can run fast in your own machine as a 
docker container of course, but here you don't even need that because all the binary and python dependencies have been provided, including also the trained models and the pre-trained embeddings. 

To reproduce the results, all you need is to [enable the GitPod app to access your GitHub account](https://gitpod.io/#https://github.com/yijunyu/demo-vscode-fast) so that the commands can be run on a remote server belonging to yourself. 

## initialisation

On first run, in the terminal type:
```bash
. .bashrc
```

## usage
Two Java example code are provided to test the algorithm classification deep learning tool. 
```bash
./run.sh 1.java
./run.sh 103.java
```

## Open the generated HTML file

Click at the Preview button to see the visualization results, which shows which parts of the code gains the attention by the classification algorithm.

The correctly classified label will be in blue, and the wrongly classified label will be in red. 

## References

Nghi D. Q. BUI, Yijun YU, Lingxiao JIANG. "[Bilateral Dependency Neural Networks for Cross-Language Algorithm Classification](https://bdqnghi.github.io/files/SANER_2019_bilateral_dependency.pdf)", In the 26th edition of the IEEE International Conference on Software Analysis, Evolution and Reengineering, Research Track, Hangzhou, China, February 24-27, 2019.

Nghi D. Q. BUI, Lingxiao JIANG, and Yijun YU. "[Cross-Language Learning for Program Classification Using Bilateral Tree-Based Convolutional Neural Networks](https://bdqnghi.github.io/files/AAAI_18_cross_language_learning.pdf)", In the proceedings of the 32nd AAAI Conference on Artificial Intelligence (AAAI) Workshop on NLP for Software Engineering, New Orleans, Louisiana, USA, 2018.

Miltiadis Allamanis, Marc Brockschmidt, Mahmoud Khademi. "[Learning to Represent Programs with Graphs](https://arxiv.org/abs/1711.00740)", In: 6th International Conference on Language Representations (ICLR), 2018.

Y Li, D Tarlow, M Brockschmidt, R Zemel. "[Gated graph sequence neural networks](https://arxiv.org/abs/1511.05493)", In: 4th International Conference on Language Representations (ICLR), 2016.

Lili Mou, Ge Li, Lu Zhang, Tao Wang, Zhi Jin: "[Convolutional Neural Networks over Tree Structures for Programming Language Processing](https://arxiv.org/abs/1409.5718)". In: AAAI 2016: 1287-1293
