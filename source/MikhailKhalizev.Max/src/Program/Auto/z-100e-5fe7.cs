using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("17eb686a-d865-4aa4-b37b-99ab05c40c3b")]
        public void Method_100e_5fe7()
        {
            ii(0x100e_5fe7, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100e_5fec, 5); calld(Definitions.sys_check_available_stack_size, 0x7_fd61); /* call 0x10165d52 */
            ii(0x100e_5ff1, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_5ff2, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_5ff3, 1); pushd(esi);                             /* push esi */
            ii(0x100e_5ff4, 1); pushd(edi);                             /* push edi */
            ii(0x100e_5ff5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_5ff6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_5ff8, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100e_5ffe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_6001, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_6004, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_6008, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x100e_600b, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_600e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_6012, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x100e_6015, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_6018, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_601b, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_601e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_6021, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_6024, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_6027, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_602a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_602d, 5); calld(0x100f_f562, 0x1_9530);           /* call 0x100ff562 */
            ii(0x100e_6032, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_6034, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_6035, 1); popd(edi);                              /* pop edi */
            ii(0x100e_6036, 1); popd(esi);                              /* pop esi */
            ii(0x100e_6037, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_6038, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_6039, 1); retd(); return;                         /* ret */
        }
    }
}
