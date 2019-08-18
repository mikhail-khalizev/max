using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4819d685-6677-4f30-9b51-0c2f27d82690")]
        public void Method_1010_2d8f()
        {
            ii(0x1010_2d8f, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_2d94, 5); calld(Definitions.sys_check_available_stack_size, 0x6_2fb9); /* call 0x10165d52 */
            ii(0x1010_2d99, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_2d9a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_2d9b, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2d9c, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2d9d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2d9e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2da0, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_2da6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_2da9, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_2dac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_2daf, 5); calld(0x1007_6b90, -0x8_c224);          /* call 0x10076b90 */
            ii(0x1010_2db4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1010_2db7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_2dba, 5); calld(0x1013_c0fa, 0x3_933b);           /* call 0x1013c0fa */
            ii(0x1010_2dbf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_2dc2, 5); calld(0x1007_6338, -0x8_ca8f);          /* call 0x10076338 */
            ii(0x1010_2dc7, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1010_2dca, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_2dcc, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_2dce, 5); calld(0x1007_64b8, -0x8_c91b);          /* call 0x100764b8 */
        l_0x1010_2dd3:
            ii(0x1010_2dd3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_2dd5, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1010_2dd8, 5); calld(0x1013_ad71, 0x3_7f94);           /* call 0x1013ad71 */
            ii(0x1010_2ddd, 2); test(al, al);                           /* test al, al */
            ii(0x1010_2ddf, 2); if(jzd(0x1010_2dfd, 0x1c)) goto l_0x1010_2dfd; /* jz 0x10102dfd */
            ii(0x1010_2de1, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1010_2de4, 5); calld(0x1007_6408, -0x8_c9e1);          /* call 0x10076408 */
            ii(0x1010_2de9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_2deb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_2dee, 5); calld(0x1013_c25c, 0x3_9469);           /* call 0x1013c25c */
            ii(0x1010_2df3, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1010_2df6, 5); calld(0x1007_6bf8, -0x8_c203);          /* call 0x10076bf8 */
            ii(0x1010_2dfb, 2); jmpd(0x1010_2dd3, -0x2a); goto l_0x1010_2dd3; /* jmp 0x10102dd3 */
        l_0x1010_2dfd:
            ii(0x1010_2dfd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_2dff, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1010_2e02, 5); calld(0x1007_5f6c, -0x8_ce9b);          /* call 0x10075f6c */
            ii(0x1010_2e07, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2e09, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_2e0a, 1); popd(edi);                              /* pop edi */
            ii(0x1010_2e0b, 1); popd(esi);                              /* pop esi */
            ii(0x1010_2e0c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_2e0d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_2e0e, 1); retd(); return;                         /* ret */
        }
    }
}
