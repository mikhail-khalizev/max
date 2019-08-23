using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_2a44-6e7e8bec")]
        public void Method_1007_2a44()
        {
            ii(0x1007_2a44, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_2a49, 5); calld(Definitions.sys_check_available_stack_size, 0xf_3304); /* call 0x10165d52 */
            ii(0x1007_2a4e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_2a4f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_2a50, 1); pushd(edx);                             /* push edx */
            ii(0x1007_2a51, 1); pushd(esi);                             /* push esi */
            ii(0x1007_2a52, 1); pushd(edi);                             /* push edi */
            ii(0x1007_2a53, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_2a54, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2a56, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_2a5c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_2a5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2a62, 4); cmp(memb_a32[ds, eax + 0x4e], 0);       /* cmp byte [eax+0x4e], 0x0 */
            ii(0x1007_2a66, 2); if(jnzd(0x1007_2a6e, 0x6)) goto l_0x1007_2a6e; /* jnz 0x10072a6e */
            ii(0x1007_2a68, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_2a6c, 2); jmpd(0x1007_2ad6, 0x68); goto l_0x1007_2ad6; /* jmp 0x10072ad6 */
        l_0x1007_2a6e:
            ii(0x1007_2a6e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_2a70, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2a73, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1007_2a76, 5); calld(0x1013_ad11, 0xc_8296);           /* call 0x1013ad11 */
            ii(0x1007_2a7b, 2); test(al, al);                           /* test al, al */
            ii(0x1007_2a7d, 2); if(jzd(0x1007_2a85, 0x6)) goto l_0x1007_2a85; /* jz 0x10072a85 */
            ii(0x1007_2a7f, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1007_2a83, 2); jmpd(0x1007_2ad6, 0x51); goto l_0x1007_2ad6; /* jmp 0x10072ad6 */
        l_0x1007_2a85:
            ii(0x1007_2a85, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2a88, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1007_2a8b, 5); calld(0x1007_69d8, 0x3f48);             /* call 0x100769d8 */
            ii(0x1007_2a90, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_2a93, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_2a96, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1007_2a99, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_2a9c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_2a9f, 3); calld_abs(memd_a32[ds, ebx + 0x24]);    /* call dword [ebx+0x24] */
            ii(0x1007_2aa2, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1007_2aa5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2aa8, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1007_2aab, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_2ab0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_2ab3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_2ab5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2ab8, 3); mov(al, memb_a32[ds, eax + 0x64]);      /* mov al, [eax+0x64] */
            ii(0x1007_2abb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_2ac0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_2ac2, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1007_2ac4, 2); if(jged(0x1007_2acc, 0x6)) goto l_0x1007_2acc; /* jge 0x10072acc */
            ii(0x1007_2ac6, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_2aca, 2); jmpd(0x1007_2ad0, 0x4); goto l_0x1007_2ad0; /* jmp 0x10072ad0 */
        l_0x1007_2acc:
            ii(0x1007_2acc, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1007_2ad0:
            ii(0x1007_2ad0, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1007_2ad3, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x1007_2ad6:
            ii(0x1007_2ad6, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1007_2ad9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_2adb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_2adc, 1); popd(edi);                              /* pop edi */
            ii(0x1007_2add, 1); popd(esi);                              /* pop esi */
            ii(0x1007_2ade, 1); popd(edx);                              /* pop edx */
            ii(0x1007_2adf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_2ae0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_2ae1, 1); retd();                                 /* ret */
        }
    }
}
