using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ac98-70078fdb")]
        public void Method_0018_ac98()
        {
            ii(0x18_ac98, 1); popw(bx);                                 /* pop bx */
            ii(0x18_ac99, 3); mov(dx, 0x1301);                          /* mov dx, 0x1301 */
            ii(0x18_ac9c, 3); mov(cl, memb_a16[ss, bp + 0x16]);         /* mov cl, [bp+0x16] */
            ii(0x18_ac9f, 2); cmp(cl, dl);                              /* cmp cl, dl */
            ii(0x18_aca1, 2); if(jbw(0x18_acc8, 0x25)) goto l_0x18_acc8; /* jb 0xacc8 */
            ii(0x18_aca3, 4); cmp(memb_a16[ds, 0x1185], dl);            /* cmp [0x1185], dl */
            ii(0x18_aca7, 2); if(jaw(0x18_acc8, 0x1f)) goto l_0x18_acc8; /* ja 0xacc8 */
            ii(0x18_aca9, 2); if(jbw(0x18_acbe, 0x13)) goto l_0x18_acbe; /* jb 0xacbe */
            ii(0x18_acab, 2); mov(ch, cl);                              /* mov ch, cl */
            ii(0x18_acad, 3); mov(ax, memw_a16[ds, 0x4a]);              /* mov ax, [0x4a] */
            ii(0x18_acb0, 2); sub(ch, ah);                              /* sub ch, ah */
            ii(0x18_acb2, 3); cmp(ch, 0x8);                             /* cmp ch, 0x8 */
            ii(0x18_acb5, 2); if(jbw(0x18_acbe, 0x7)) goto l_0x18_acbe; /* jb 0xacbe */
            ii(0x18_acb7, 2); sub(cl, al);                              /* sub cl, al */
            ii(0x18_acb9, 3); cmp(cl, 0x8);                             /* cmp cl, 0x8 */
            ii(0x18_acbc, 2); if(jaew(0x18_acc8, 0xa)) goto l_0x18_acc8; /* jae 0xacc8 */
        l_0x18_acbe:
            ii(0x18_acbe, 3); mov(es, memw_a16[ss, bp + 0x4]);          /* mov es, [bp+0x4] */
            ii(0x18_acc1, 3); mov(ax, 0xff40);                          /* mov ax, 0xff40 */
            ii(0x18_acc4, 1); pushw(cs);                                /* push cs */
            ii(0x18_acc5, 3); callw(0x18_a366, -0x962);                 /* call 0xa366 */
        l_0x18_acc8:
            ii(0x18_acc8, 3); if(jmpw_func(0x18_a838, -0x493)) return;  /* jmp 0xa838 */
        }
    }
}
