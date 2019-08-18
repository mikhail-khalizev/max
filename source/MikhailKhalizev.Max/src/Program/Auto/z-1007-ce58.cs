using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_ce58-793b853a")]
        public void Method_1007_ce58()
        {
            ii(0x1007_ce58, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_ce5d, 5); calld(Definitions.sys_check_available_stack_size, 0xe_8ef0); /* call 0x10165d52 */
            ii(0x1007_ce62, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_ce63, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_ce64, 1); pushd(edx);                             /* push edx */
            ii(0x1007_ce65, 1); pushd(esi);                             /* push esi */
            ii(0x1007_ce66, 1); pushd(edi);                             /* push edi */
            ii(0x1007_ce67, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_ce68, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_ce6a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_ce70, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_ce73, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ce75, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ce78, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_ce7b, 5); calld(0x1013_ad11, 0xb_de91);           /* call 0x1013ad11 */
            ii(0x1007_ce80, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ce82, 6); if(jnzd(0x1007_cf0d, 0x85)) goto l_0x1007_cf0d; /* jnz 0x1007cf0d */
        l_0x1007_ce88:
            ii(0x1007_ce88, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ce8b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_ce8e, 5); calld(0x1007_63a0, -0x6af3);            /* call 0x100763a0 */
            ii(0x1007_ce93, 3); mov(al, memb_a32[ds, eax + 0x12]);      /* mov al, [eax+0x12] */
            ii(0x1007_ce96, 2); and(al, 0x40);                          /* and al, 0x40 */
            ii(0x1007_ce98, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1007_ce9b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ce9e, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_cea1, 5); calld(0x1007_6bf8, -0x62ae);            /* call 0x10076bf8 */
            ii(0x1007_cea6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_cea8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ceab, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_ceae, 5); calld(0x1013_ad11, 0xb_de5e);           /* call 0x1013ad11 */
            ii(0x1007_ceb3, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ceb5, 2); if(jzd(0x1007_cebd, 0x6)) goto l_0x1007_cebd; /* jz 0x1007cebd */
            ii(0x1007_ceb7, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1007_cebb, 2); if(jzd(0x1007_cebf, 0x2)) goto l_0x1007_cebf; /* jz 0x1007cebf */
        l_0x1007_cebd:
            ii(0x1007_cebd, 2); jmpd(0x1007_ced8, 0x19); goto l_0x1007_ced8; /* jmp 0x1007ced8 */
        l_0x1007_cebf:
            ii(0x1007_cebf, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1007_cec4, 5); calld(0x1007_6338, -0x6b91);            /* call 0x10076338 */
            ii(0x1007_cec9, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1007_cecc, 3); add(ebx, 0x13);                         /* add ebx, 0x13 */
            ii(0x1007_cecf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_ced1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_ced3, 5); calld(0x1007_643c, -0x6a9c);            /* call 0x1007643c */
        l_0x1007_ced8:
            ii(0x1007_ced8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ceda, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_cedd, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_cee0, 5); calld(0x1013_ad71, 0xb_de8c);           /* call 0x1013ad71 */
            ii(0x1007_cee5, 2); test(al, al);                           /* test al, al */
            ii(0x1007_cee7, 2); if(jzd(0x1007_cf06, 0x1d)) goto l_0x1007_cf06; /* jz 0x1007cf06 */
            ii(0x1007_cee9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ceec, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_ceef, 5); calld(0x1007_63a0, -0x6b54);            /* call 0x100763a0 */
            ii(0x1007_cef4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_cef6, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_cef9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_cefc, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1007_ceff, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_cf02, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_cf04, 2); if(jnzd(0x1007_cf08, 0x2)) goto l_0x1007_cf08; /* jnz 0x1007cf08 */
        l_0x1007_cf06:
            ii(0x1007_cf06, 2); jmpd(0x1007_cf0d, 0x5); goto l_0x1007_cf0d; /* jmp 0x1007cf0d */
        l_0x1007_cf08:
            ii(0x1007_cf08, 5); jmpd(0x1007_ce88, -0x85); goto l_0x1007_ce88; /* jmp 0x1007ce88 */
        l_0x1007_cf0d:
            ii(0x1007_cf0d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_cf0f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_cf10, 1); popd(edi);                              /* pop edi */
            ii(0x1007_cf11, 1); popd(esi);                              /* pop esi */
            ii(0x1007_cf12, 1); popd(edx);                              /* pop edx */
            ii(0x1007_cf13, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_cf14, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_cf15, 1); retd(); return;                         /* ret */
        }
    }
}
