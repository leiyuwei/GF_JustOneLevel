using GameFramework.Fsm;
using UnityEngine;

public class HeroIdleState : FsmState<HeroLogic> {
    /// <summary>
    /// 有限状态机状态初始化时调用。
    /// </summary>
    /// <param name="fsm">有限状态机引用。</param>
    protected override void OnInit (IFsm<HeroLogic> fsm) { }

    /// <summary>
    /// 有限状态机状态进入时调用。
    /// </summary>
    /// <param name="fsm">有限状态机引用。</param>
    protected override void OnEnter (IFsm<HeroLogic> fsm) {
        fsm.Owner.ChangeAnimation (HeroAnimationState.idle);
    }

    /// <summary>
    /// 有限状态机状态轮询时调用。
    /// </summary>
    /// <param name="fsm">有限状态机引用。</param>
    /// <param name="elapseSeconds">逻辑流逝时间，以秒为单位。</param>
    /// <param name="realElapseSeconds">真实流逝时间，以秒为单位。</param>
    protected override void OnUpdate (IFsm<HeroLogic> fsm, float elapseSeconds, float realElapseSeconds) {
        float inputVertical = Input.GetAxis ("Vertical");
        if (inputVertical != 0) {
            /* 移动 */
            ChangeState<HeroWalkState>(fsm);
        }
    }

    /// <summary>
    /// 有限状态机状态离开时调用。
    /// </summary>
    /// <param name="fsm">有限状态机引用。</param>
    /// <param name="isShutdown">是否是关闭有限状态机时触发。</param>
    protected override void OnLeave (IFsm<HeroLogic> fsm, bool isShutdown) {

    }

    /// <summary>
    /// 有限状态机状态销毁时调用。
    /// </summary>
    /// <param name="fsm">有限状态机引用。</param>
    protected override void OnDestroy (IFsm<HeroLogic> fsm) {
        base.OnDestroy (fsm);
    }

}