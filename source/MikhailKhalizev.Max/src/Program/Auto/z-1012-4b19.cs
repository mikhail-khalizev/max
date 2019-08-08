using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a6781d2b-37e1-47a3-994a-d65747f87a5d")]
        public void Method_1012_4b19()
        {
            ii(0x1012_4b19, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1012_4b1e, 5); calld(Definitions.sys_check_available_stack_size, 0x4_122f); /* call 0x10165d52 */
            ii(0x1012_4b23, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_4b24, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_4b25, 1); pushd(edx);                             /* push edx */
            ii(0x1012_4b26, 1); pushd(esi);                             /* push esi */
            ii(0x1012_4b27, 1); pushd(edi);                             /* push edi */
            ii(0x1012_4b28, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_4b29, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4b2b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_4b31, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_4b34, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_4b36, 5); calld(0x100e_883d, -0x3_c2fe);          /* call 0x100e883d */
            ii(0x1012_4b3b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_4b3e, 5); mov(eax, memd_a32[ds, 0x101c_59c4]);    /* mov eax, [0x101c59c4] */
            ii(0x1012_4b43, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_4b46, 5); cmp(eax, 0x197);                        /* cmp eax, 0x197 */
            ii(0x1012_4b4b, 2); if(jled(0x1012_4b5e, 0x11)) goto l_0x1012_4b5e; /* jle 0x10124b5e */
            ii(0x1012_4b4d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_4b50, 5); calld(0x1010_eda6, -0x1_5daf);          /* call 0x1010eda6 */
            ii(0x1012_4b55, 9); mov(memw_a32[ds, 0x101c_59c6], 0xd7);   /* mov word [0x101c59c6], 0xd7 */
        l_0x1012_4b5e:
            ii(0x1012_4b5e, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_4b63, 5); calld(/* sys */ 0x1016_a24c, 0x4_56e4); /* call 0x1016a24c */
            ii(0x1012_4b68, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_4b6d, 1); pushd(eax);                             /* push eax */
            ii(0x1012_4b6e, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1012_4b73, 1); pushd(eax);                             /* push eax */
            ii(0x1012_4b74, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_4b77, 1); pushd(eax);                             /* push eax */
            ii(0x1012_4b78, 5); mov(eax, memd_a32[ds, 0x101c_59c4]);    /* mov eax, [0x101c59c4] */
            ii(0x1012_4b7d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_4b80, 1); pushd(eax);                             /* push eax */
            ii(0x1012_4b81, 5); mov(ecx, 0x163);                        /* mov ecx, 0x163 */
            ii(0x1012_4b86, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1012_4b8b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_4b8e, 3); mov(edx, memd_a32[ds, eax + 0x16]);     /* mov edx, [eax+0x16] */
            ii(0x1012_4b91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_4b94, 5); calld(0x1011_60dc, -0xeabd);            /* call 0x101160dc */
            ii(0x1012_4b99, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_4b9b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_4b9c, 1); popd(edi);                              /* pop edi */
            ii(0x1012_4b9d, 1); popd(esi);                              /* pop esi */
            ii(0x1012_4b9e, 1); popd(edx);                              /* pop edx */
            ii(0x1012_4b9f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_4ba0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_4ba1, 1); retd(); return;                         /* ret */
        }
    }
}
