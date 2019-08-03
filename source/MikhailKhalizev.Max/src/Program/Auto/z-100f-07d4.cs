using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("de455fcb-52e8-41fc-83e2-54a068d23fed")]
        public void Method_100f_07d4()
        {
            ii(0x100f_07d4, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100f_07d9, 5); calld(Definitions.sys_check_available_stack_size, 0x75574); /* call 0x10165d52 */
            ii(0x100f_07de, 1); pushd(esi);                             /* push esi */
            ii(0x100f_07df, 1); pushd(edi);                             /* push edi */
            ii(0x100f_07e0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_07e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_07e3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_07e9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_07ec, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100f_07ef, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100f_07f2, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100f_07f5, 5); calld(/* sys */ 0x1016_66b0, 0x75eb6);  /* call 0x101666b0 */
            ii(0x100f_07fa, 5); calld(/* sys */ 0x1017_1880, 0x81081);  /* call 0x10171880 */
            ii(0x100f_07ff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_0802, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0803, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_0806, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0807, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_080a, 1); pushd(eax);                             /* push eax */
            ii(0x100f_080b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_080e, 1); pushd(eax);                             /* push eax */
            ii(0x100f_080f, 5); mov(eax, 0x101a_224c);                  /* mov eax, 0x101a224c */ /* "Assertion failed: %s at line %li in file %s.\nReason: %s" */
            ii(0x100f_0814, 1); pushd(eax);                             /* push eax */
            ii(0x100f_0815, 5); calld(Definitions.sys_printf, 0x7be22); /* call 0x1016c63c */
            ii(0x100f_081a, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x100f_081d, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100f_0822, 5); calld(Definitions.sys_exit, 0x7be38);   /* call 0x1016c65f */
            ii(0x100f_0827, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_0829, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_082a, 1); popd(edi);                              /* pop edi */
            ii(0x100f_082b, 1); popd(esi);                              /* pop esi */
            ii(0x100f_082c, 1); retd(); return;                         /* ret */
        }
    }
}
