using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7d5145ea-6650-4e6f-81d4-e32b9a1744b9")]
        public void Method_100b_cbe9()
        {
            ii(0x100b_cbe9, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100b_cbee, 5); calld(Definitions.sys_check_available_stack_size, 0xa_915f); /* call 0x10165d52 */
            ii(0x100b_cbf3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_cbf4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_cbf5, 1); pushd(esi);                             /* push esi */
            ii(0x100b_cbf6, 1); pushd(edi);                             /* push edi */
            ii(0x100b_cbf7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_cbf8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_cbfa, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_cc00, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_cc03, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_cc06, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_cc0b, 5); calld(0x1007_6338, -0x4_68d8);          /* call 0x10076338 */
            ii(0x100b_cc10, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100b_cc13, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_cc15, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_cc17, 5); calld(0x1007_64b8, -0x4_6764);          /* call 0x100764b8 */
            ii(0x100b_cc1c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_cc1f, 5); calld(0x1007_623c, -0x4_69e8);          /* call 0x1007623c */
            ii(0x100b_cc24, 4); mov(ax, memw_a32[ds, eax + 0x17]);      /* mov ax, [eax+0x17] */
            ii(0x100b_cc28, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_cc2b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_cc2e, 4); imul(eax, memd_a32[ss, ebp - 0x14]);    /* imul eax, [ebp-0x14] */
            ii(0x100b_cc32, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_cc35, 2); jmpd(0x100b_cc3f, 0x8); goto l_0x100b_cc3f; /* jmp 0x100bcc3f */
        l_0x100b_cc37:
            ii(0x100b_cc37, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_cc3a, 5); calld(0x1007_6bf8, -0x4_6047);          /* call 0x10076bf8 */
        l_0x100b_cc3f:
            ii(0x100b_cc3f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cc41, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_cc44, 5); calld(0x1013_ad71, 0x7_e128);           /* call 0x1013ad71 */
            ii(0x100b_cc49, 2); test(al, al);                           /* test al, al */
            ii(0x100b_cc4b, 2); if(jzd(0x100b_cc8e, 0x41)) goto l_0x100b_cc8e; /* jz 0x100bcc8e */
            ii(0x100b_cc4d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_cc50, 5); calld(0x1007_63a0, -0x4_68b5);          /* call 0x100763a0 */
            ii(0x100b_cc55, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cc57, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_cc5a, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100b_cc5e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_cc60, 2); if(jnzd(0x100b_cc7a, 0x18)) goto l_0x100b_cc7a; /* jnz 0x100bcc7a */
            ii(0x100b_cc62, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_cc65, 5); calld(0x1007_63d4, -0x4_6896);          /* call 0x100763d4 */
            ii(0x100b_cc6a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_cc6c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_cc6f, 5); calld(0x1007_0d01, -0x4_bf73);          /* call 0x10070d01 */
            ii(0x100b_cc74, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100b_cc78, 2); if(jled(0x100b_cc7c, 0x2)) goto l_0x100b_cc7c; /* jle 0x100bcc7c */
        l_0x100b_cc7a:
            ii(0x100b_cc7a, 2); jmpd(0x100b_cc8c, 0x10); goto l_0x100b_cc8c; /* jmp 0x100bcc8c */
        l_0x100b_cc7c:
            ii(0x100b_cc7c, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_cc80, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cc82, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_cc85, 5); calld(0x1007_5f6c, -0x4_6d1e);          /* call 0x10075f6c */
            ii(0x100b_cc8a, 2); jmpd(0x100b_cca8, 0x1c); goto l_0x100b_cca8; /* jmp 0x100bcca8 */
        l_0x100b_cc8c:
            ii(0x100b_cc8c, 2); jmpd(0x100b_cc37, -0x57); goto l_0x100b_cc37; /* jmp 0x100bcc37 */
        l_0x100b_cc8e:
            ii(0x100b_cc8e, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_cc92, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_cc94, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_cc97, 5); calld(0x1007_5f6c, -0x4_6d30);          /* call 0x10075f6c */
            ii(0x100b_cc9c, 2); jmpd(0x100b_cca8, 0xa); goto l_0x100b_cca8; /* jmp 0x100bcca8 */
        //    ii(0x100b_cc9e, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100b_cca0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
        //    ii(0x100b_cca3, 5); calld(0x1007_5f6c, -0x4_6d3c);          /* call 0x10075f6c */
        l_0x100b_cca8:
            ii(0x100b_cca8, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_ccab, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_ccad, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_ccae, 1); popd(edi);                              /* pop edi */
            ii(0x100b_ccaf, 1); popd(esi);                              /* pop esi */
            ii(0x100b_ccb0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_ccb1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_ccb2, 1); retd(); return;                         /* ret */
        }
    }
}
