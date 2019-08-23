using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_d1d3-e50a3878")]
        public void Method_1007_d1d3()
        {
            ii(0x1007_d1d3, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_d1d8, 5); calld(Definitions.sys_check_available_stack_size, 0xe_8b75); /* call 0x10165d52 */
            ii(0x1007_d1dd, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_d1de, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_d1df, 1); pushd(edx);                             /* push edx */
            ii(0x1007_d1e0, 1); pushd(esi);                             /* push esi */
            ii(0x1007_d1e1, 1); pushd(edi);                             /* push edi */
            ii(0x1007_d1e2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_d1e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_d1e5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_d1eb, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_d1ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_d1f1, 5); calld(0x1007_6338, -0x6ebe);            /* call 0x10076338 */
            ii(0x1007_d1f6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_d1f8, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_d1fb, 5); calld(0x1007_64b8, -0x6d48);            /* call 0x100764b8 */
            ii(0x1007_d200, 2); jmpd(0x1007_d20a, 0x8); goto l_0x1007_d20a; /* jmp 0x1007d20a */
        l_0x1007_d202:
            ii(0x1007_d202, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_d205, 5); calld(0x1007_6bf8, -0x6612);            /* call 0x10076bf8 */
        l_0x1007_d20a:
            ii(0x1007_d20a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_d20c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_d20f, 5); calld(0x1013_ad71, 0xb_db5d);           /* call 0x1013ad71 */
            ii(0x1007_d214, 2); test(al, al);                           /* test al, al */
            ii(0x1007_d216, 2); if(jzd(0x1007_d237, 0x1f)) goto l_0x1007_d237; /* jz 0x1007d237 */
            ii(0x1007_d218, 5); calld(0x1008_a79c, 0xd57f);             /* call 0x1008a79c */
            ii(0x1007_d21d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_d21f, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_d221, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_d224, 5); calld(0x1007_63d4, -0x6e55);            /* call 0x100763d4 */
            ii(0x1007_d229, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_d22b, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_d230, 5); calld(0x100a_53ac, 0x2_8177);           /* call 0x100a53ac */
            ii(0x1007_d235, 2); jmpd(0x1007_d202, -0x35); goto l_0x1007_d202; /* jmp 0x1007d202 */
        l_0x1007_d237:
            ii(0x1007_d237, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_d23a, 5); calld(0x1013_a6f4, 0xb_d4b5);           /* call 0x1013a6f4 */
            ii(0x1007_d23f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_d241, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_d244, 5); calld(0x1007_5f6c, -0x72dd);            /* call 0x10075f6c */
            ii(0x1007_d249, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_d24b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_d24c, 1); popd(edi);                              /* pop edi */
            ii(0x1007_d24d, 1); popd(esi);                              /* pop esi */
            ii(0x1007_d24e, 1); popd(edx);                              /* pop edx */
            ii(0x1007_d24f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_d250, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_d251, 1); retd();                                 /* ret */
        }
    }
}
