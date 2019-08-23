using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_09c4-c2117329")]
        public void Method_1007_09c4()
        {
            ii(0x1007_09c4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_09c9, 5); calld(Definitions.sys_check_available_stack_size, 0xf_5384); /* call 0x10165d52 */
            ii(0x1007_09ce, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_09cf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_09d0, 1); pushd(edx);                             /* push edx */
            ii(0x1007_09d1, 1); pushd(esi);                             /* push esi */
            ii(0x1007_09d2, 1); pushd(edi);                             /* push edi */
            ii(0x1007_09d3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_09d4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_09d6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_09dc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_09df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_09e2, 5); calld(0x1007_6338, 0x5951);             /* call 0x10076338 */
            ii(0x1007_09e7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_09e9, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_09ec, 5); calld(0x1007_64b8, 0x5ac7);             /* call 0x100764b8 */
        l_0x1007_09f1:
            ii(0x1007_09f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_09f3, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_09f6, 5); calld(0x1013_ad71, 0xc_a376);           /* call 0x1013ad71 */
            ii(0x1007_09fb, 2); test(al, al);                           /* test al, al */
            ii(0x1007_09fd, 2); if(jzd(0x1007_0a16, 0x17)) goto l_0x1007_0a16; /* jz 0x10070a16 */
            ii(0x1007_09ff, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_0a02, 5); calld(0x1007_63a0, 0x5999);             /* call 0x100763a0 */
            ii(0x1007_0a07, 5); calld(0x1014_f1f2, 0xd_e7e6);           /* call 0x1014f1f2 */
            ii(0x1007_0a0c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_0a0f, 5); calld(0x1007_6bf8, 0x61e4);             /* call 0x10076bf8 */
            ii(0x1007_0a14, 2); jmpd(0x1007_09f1, -0x25); goto l_0x1007_09f1; /* jmp 0x100709f1 */
        l_0x1007_0a16:
            ii(0x1007_0a16, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0a18, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_0a1b, 5); calld(0x1007_5f6c, 0x554c);             /* call 0x10075f6c */
            ii(0x1007_0a20, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_0a22, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_0a23, 1); popd(edi);                              /* pop edi */
            ii(0x1007_0a24, 1); popd(esi);                              /* pop esi */
            ii(0x1007_0a25, 1); popd(edx);                              /* pop edx */
            ii(0x1007_0a26, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_0a27, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_0a28, 1); retd();                                 /* ret */
        }
    }
}
