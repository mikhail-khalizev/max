using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("df36c5f1-efc9-4149-b1c2-8c10f3ee15cc")]
        public void Method_1015_7c72()
        {
            ii(0x1015_7c72, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_7c77, 5); calld(Definitions.sys_check_available_stack_size, 0xe0d6); /* call 0x10165d52 */
            ii(0x1015_7c7c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_7c7d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_7c7e, 1); pushd(edx);                             /* push edx */
            ii(0x1015_7c7f, 1); pushd(esi);                             /* push esi */
            ii(0x1015_7c80, 1); pushd(edi);                             /* push edi */
            ii(0x1015_7c81, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_7c82, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_7c84, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_7c8a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_7c8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7c90, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1015_7c94, 2); if(jnzd(0x1015_7c9f, 0x9)) goto l_0x1015_7c9f; /* jnz 0x10157c9f */
            ii(0x1015_7c96, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7c99, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1);     /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1015_7c9d, 2); if(jzd(0x1015_7cb3, 0x14)) goto l_0x1015_7cb3; /* jz 0x10157cb3 */
        l_0x1015_7c9f:
            ii(0x1015_7c9f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7ca2, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1015_7ca6, 2); if(jnzd(0x1015_7cb1, 0x9)) goto l_0x1015_7cb1; /* jnz 0x10157cb1 */
            ii(0x1015_7ca8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7cab, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1e);    /* cmp byte [eax+0x3e], 0x1e */
            ii(0x1015_7caf, 2); if(jzd(0x1015_7cb3, 0x2)) goto l_0x1015_7cb3; /* jz 0x10157cb3 */
        l_0x1015_7cb1:
            ii(0x1015_7cb1, 2); jmpd(0x1015_7cb9, 0x6); goto l_0x1015_7cb9; /* jmp 0x10157cb9 */
        l_0x1015_7cb3:
            ii(0x1015_7cb3, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1015_7cb7, 2); jmpd(0x1015_7cbd, 0x4); goto l_0x1015_7cbd; /* jmp 0x10157cbd */
        l_0x1015_7cb9:
            ii(0x1015_7cb9, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1015_7cbd:
            ii(0x1015_7cbd, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_7cc0, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1015_7cc3, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1015_7cc6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_7cc8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_7cc9, 1); popd(edi);                              /* pop edi */
            ii(0x1015_7cca, 1); popd(esi);                              /* pop esi */
            ii(0x1015_7ccb, 1); popd(edx);                              /* pop edx */
            ii(0x1015_7ccc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_7ccd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_7cce, 1); retd(); return;                         /* ret */
        }
    }
}
