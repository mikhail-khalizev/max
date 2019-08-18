using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_7bd5-70dc7780")]
        public void Method_100f_7bd5()
        {
            ii(0x100f_7bd5, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_7bda, 5); calld(Definitions.sys_check_available_stack_size, 0x6_e173); /* call 0x10165d52 */
            ii(0x100f_7bdf, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_7be0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_7be1, 1); pushd(esi);                             /* push esi */
            ii(0x100f_7be2, 1); pushd(edi);                             /* push edi */
            ii(0x100f_7be3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_7be4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_7be6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_7bec, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_7bef, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100f_7bf2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_7bf5, 4); test(memb_a32[ds, eax + 0x14], 0x20);   /* test byte [eax+0x14], 0x20 */
            ii(0x100f_7bf9, 2); if(jzd(0x100f_7c04, 0x9)) goto l_0x100f_7c04; /* jz 0x100f7c04 */
            ii(0x100f_7bfb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_7bfe, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1);     /* cmp byte [eax+0x3d], 0x1 */
            ii(0x100f_7c02, 2); if(jnzd(0x100f_7c06, 0x2)) goto l_0x100f_7c06; /* jnz 0x100f7c06 */
        l_0x100f_7c04:
            ii(0x100f_7c04, 2); jmpd(0x100f_7c0f, 0x9); goto l_0x100f_7c0f; /* jmp 0x100f7c0f */
        l_0x100f_7c06:
            ii(0x100f_7c06, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_7c09, 4); cmp(memb_a32[ds, eax + 0x3d], 0x3);     /* cmp byte [eax+0x3d], 0x3 */
            ii(0x100f_7c0d, 2); if(jnzd(0x100f_7c11, 0x2)) goto l_0x100f_7c11; /* jnz 0x100f7c11 */
        l_0x100f_7c0f:
            ii(0x100f_7c0f, 2); jmpd(0x100f_7c1a, 0x9); goto l_0x100f_7c1a; /* jmp 0x100f7c1a */
        l_0x100f_7c11:
            ii(0x100f_7c11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_7c14, 4); cmp(memb_a32[ds, eax + 0x3d], 0x9);     /* cmp byte [eax+0x3d], 0x9 */
            ii(0x100f_7c18, 2); if(jnzd(0x100f_7c1c, 0x2)) goto l_0x100f_7c1c; /* jnz 0x100f7c1c */
        l_0x100f_7c1a:
            ii(0x100f_7c1a, 2); jmpd(0x100f_7c25, 0x9); goto l_0x100f_7c25; /* jmp 0x100f7c25 */
        l_0x100f_7c1c:
            ii(0x100f_7c1c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_7c1f, 4); cmp(memb_a32[ds, eax + 0x3e], 0xe);     /* cmp byte [eax+0x3e], 0xe */
            ii(0x100f_7c23, 2); if(jnzd(0x100f_7c27, 0x2)) goto l_0x100f_7c27; /* jnz 0x100f7c27 */
        l_0x100f_7c25:
            ii(0x100f_7c25, 2); jmpd(0x100f_7c30, 0x9); goto l_0x100f_7c30; /* jmp 0x100f7c30 */
        l_0x100f_7c27:
            ii(0x100f_7c27, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_7c2a, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_7c2e, 2); if(jnzd(0x100f_7c39, 0x9)) goto l_0x100f_7c39; /* jnz 0x100f7c39 */
        l_0x100f_7c30:
            ii(0x100f_7c30, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100f_7c37, 2); jmpd(0x100f_7c5d, 0x24); goto l_0x100f_7c5d; /* jmp 0x100f7c5d */
        l_0x100f_7c39:
            ii(0x100f_7c39, 5); mov(ecx, 0x1b);                         /* mov ecx, 0x1b */
            ii(0x100f_7c3e, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x100f_7c43, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_7c46, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_7c49, 5); calld(0x1015_c75a, 0x6_4b0c);           /* call 0x1015c75a */
            ii(0x100f_7c4e, 1); cwde();                                 /* cwde */
            ii(0x100f_7c4f, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x100f_7c51, 5); calld(0x1012_10e7, 0x2_9491);           /* call 0x101210e7 */
            ii(0x100f_7c56, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
        l_0x100f_7c5d:
            ii(0x100f_7c5d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_7c60, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_7c62, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_7c63, 1); popd(edi);                              /* pop edi */
            ii(0x100f_7c64, 1); popd(esi);                              /* pop esi */
            ii(0x100f_7c65, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_7c66, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_7c67, 1); retd(); return;                         /* ret */
        }
    }
}
