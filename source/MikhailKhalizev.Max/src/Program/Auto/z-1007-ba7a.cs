using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b450532d-d9e2-4af1-b823-fc46293850d4")]
        public void Method_1007_ba7a()
        {
            ii(0x1007_ba7a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_ba7f, 5); calld(Definitions.sys_check_available_stack_size, 0xe_a2ce); /* call 0x10165d52 */
            ii(0x1007_ba84, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_ba85, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_ba86, 1); pushd(esi);                             /* push esi */
            ii(0x1007_ba87, 1); pushd(edi);                             /* push edi */
            ii(0x1007_ba88, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_ba89, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_ba8b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_ba91, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_ba94, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_ba97, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ba99, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_ba9c, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_ba9f, 5); calld(0x1013_ad11, 0xb_f26d);           /* call 0x1013ad11 */
            ii(0x1007_baa4, 2); test(al, al);                           /* test al, al */
            ii(0x1007_baa6, 2); if(jnzd(0x1007_bacd, 0x25)) goto l_0x1007_bacd; /* jnz 0x1007bacd */
            ii(0x1007_baa8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_baab, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_baae, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_bab1, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1007_bab4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_bab7, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x1007_baba, 2); cmp(al, 0x19);                          /* cmp al, 0x19 */
            ii(0x1007_babc, 2); if(jnzd(0x1007_bacd, 0xf)) goto l_0x1007_bacd; /* jnz 0x1007bacd */
            ii(0x1007_babe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_bac1, 4); dec(memw_a32[ds, eax + 0x13]);          /* dec word [eax+0x13] */
            ii(0x1007_bac5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_bac8, 5); calld(0x1007_bd04, 0x237);              /* call 0x1007bd04 */
        l_0x1007_bacd:
            ii(0x1007_bacd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_bacf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_bad0, 1); popd(edi);                              /* pop edi */
            ii(0x1007_bad1, 1); popd(esi);                              /* pop esi */
            ii(0x1007_bad2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_bad3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_bad4, 1); retd(); return;                         /* ret */
        }
    }
}