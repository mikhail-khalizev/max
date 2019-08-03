using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f9823c45-7318-45b2-84ef-20310455df32")]
        public void Method_100f_b82b()
        {
            ii(0x100f_b82b, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x100f_b830, 5); calld(Definitions.sys_check_available_stack_size, 0x6a51d); /* call 0x10165d52 */
            ii(0x100f_b835, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_b836, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_b837, 1); pushd(edx);                             /* push edx */
            ii(0x100f_b838, 1); pushd(esi);                             /* push esi */
            ii(0x100f_b839, 1); pushd(edi);                             /* push edi */
            ii(0x100f_b83a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_b83b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_b83d, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x100f_b843, 5); calld(/* sys */ 0x1016_be34, 0x705ec);  /* call 0x1016be34 */
            ii(0x100f_b848, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x100f_b84d, 5); calld(0x1007_5fdc, -0x85876);           /* call 0x10075fdc */
            ii(0x100f_b852, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_b857, 5); calld(0x1013_51c1, 0x39965);            /* call 0x101351c1 */
            ii(0x100f_b85c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_b85e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_b860, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100f_b865, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_b867, 5); calld(0x1010_1620, 0x5db4);             /* call 0x10101620 */
            ii(0x100f_b86c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_b871, 5); calld(0x1010_0efe, 0x5688);             /* call 0x10100efe */
            ii(0x100f_b876, 5); calld(/* sys */ 0x1016_bcc4, 0x70449);  /* call 0x1016bcc4 */
            ii(0x100f_b87b, 7); mov(memb_a32[ds, 0x101c_388f], 0x1);    /* mov byte [0x101c388f], 0x1 */
            ii(0x100f_b882, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_b883, 1); popd(edi);                              /* pop edi */
            ii(0x100f_b884, 1); popd(esi);                              /* pop esi */
            ii(0x100f_b885, 1); popd(edx);                              /* pop edx */
            ii(0x100f_b886, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_b887, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_b888, 1); retd(); return;                         /* ret */
        }
    }
}