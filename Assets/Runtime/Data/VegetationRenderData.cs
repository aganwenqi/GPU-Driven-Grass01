using System;
using UnityEngine;

[Serializable]
public struct InstanceBuffer
{
    public Matrix4x4 worldMatrix;
    public Matrix4x4 worldInverseMatrix;
    public InstanceBuffer(Matrix4x4 worldMatrix)
    {
        this.worldMatrix = worldMatrix;
        this.worldInverseMatrix = worldMatrix.inverse;
    }
}

[Serializable]
public struct ClusterData
{
    public Vector3 center;
    public Vector3 extends;
    //��ǰ����cluster�е�λ��
    public int clusterIndex;

    public int clusterKindIndex;
    public ClusterData(Bounds bound)
    {
        center = bound.center;
        extends = bound.extents;
        clusterIndex = clusterKindIndex = -1;
    }

    public ClusterData(ClusterData other, int clusterIndex, int clusterKindIndex)
    {
        center = other.center;
        extends = other.extends;
        this.clusterIndex = clusterIndex;
        this.clusterKindIndex = clusterKindIndex;
    }
}

[Serializable]
public struct ClusterKindData
{

    public int argsIndex;

    //�������͵�result��ʼλ��
    public int kindResultStart;

    //�ж���LOD
    public int lodNum;

    //�����͵�Cluster�ж��ٸ�
    public int elementNum;

    //ֻ����4��LOD
    public Vector4 lodRelative;


    public ClusterKindData(int argsIndex, int kindResultStart, int elementNum, int lodNum, Vector4 lodRelative, int shadowLODLevel)
    {
        this.argsIndex = argsIndex;
        this.kindResultStart = kindResultStart;
        this.elementNum = elementNum;
        this.lodNum = lodNum;
        this.lodRelative = lodRelative;
    }
}


