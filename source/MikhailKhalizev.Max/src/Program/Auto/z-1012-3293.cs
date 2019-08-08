using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5f966326-6c5a-4026-91ac-e918d3a8b261")]
        public void Method_1012_3293()
        {
            ii(0x1012_3293, 5); pushd(0x74);                            /* push 0x74 */
            ii(0x1012_3298, 5); calld(Definitions.sys_check_available_stack_size, 0x4_2ab5); /* call 0x10165d52 */
            ii(0x1012_329d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_329e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_329f, 1); pushd(edx);                             /* push edx */
            ii(0x1012_32a0, 1); pushd(esi);                             /* push esi */
            ii(0x1012_32a1, 1); pushd(edi);                             /* push edi */
            ii(0x1012_32a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_32a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_32a5, 6); sub(esp, 0x58);                         /* sub esp, 0x58 */
            ii(0x1012_32ab, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_32ae, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1012_32b2, 5); mov(ebx, 0x6cd);                        /* mov ebx, 0x6cd */
            ii(0x1012_32b7, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1012_32bb, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1012_32be, 5); calld(0x1012_13b0, -0x1f13);            /* call 0x101213b0 */
            ii(0x1012_32c3, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1012_32c6, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1012_32ca, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1012_32cd, 5); calld(0x1012_31dd, -0xf5);              /* call 0x101231dd */
            ii(0x1012_32d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_32d4, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1012_32d7, 5); calld(0x1012_1791, -0x1b4b);            /* call 0x10121791 */
            ii(0x1012_32dc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_32de, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_32df, 1); popd(edi);                              /* pop edi */
            ii(0x1012_32e0, 1); popd(esi);                              /* pop esi */
            ii(0x1012_32e1, 1); popd(edx);                              /* pop edx */
            ii(0x1012_32e2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_32e3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_32e4, 1); retd(); return;                         /* ret */
        }
    }
}
