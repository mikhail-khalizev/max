using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("56ada970-baf9-4610-90bd-09ecb939b9af")]
        public void Method_100a_3c39()
        {
            ii(0x100a_3c39, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_3c3e, 5); calld(Definitions.sys_check_available_stack_size, 0xc_210f); /* call 0x10165d52 */
            ii(0x100a_3c43, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_3c44, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3c45, 1); pushd(edx);                             /* push edx */
            ii(0x100a_3c46, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3c47, 1); pushd(edi);                             /* push edi */
            ii(0x100a_3c48, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_3c49, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3c4b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_3c51, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_3c54, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_3c56, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_3c59, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3c5c, 5); calld(0x1013_ad71, 0x9_7110);           /* call 0x1013ad71 */
            ii(0x100a_3c61, 2); test(al, al);                           /* test al, al */
            ii(0x100a_3c63, 2); if(jzd(0x100a_3c7c, 0x17)) goto l_0x100a_3c7c; /* jz 0x100a3c7c */
            ii(0x100a_3c65, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_3c67, 5); mov(edx, 0x100);                        /* mov edx, 0x100 */
            ii(0x100a_3c6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_3c6f, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3c72, 5); calld(0x1007_6574, -0x2_d703);          /* call 0x10076574 */
            ii(0x100a_3c77, 5); calld(0x100a_b120, 0x74a4);             /* call 0x100ab120 */
        l_0x100a_3c7c:
            ii(0x100a_3c7c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_3c7f, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3c82, 5); calld(0x1007_6574, -0x2_d713);          /* call 0x10076574 */
            ii(0x100a_3c87, 5); calld(0x1015_26ac, 0xa_ea20);           /* call 0x101526ac */
            ii(0x100a_3c8c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_3c8e, 2); if(jzd(0x100a_3ca7, 0x17)) goto l_0x100a_3ca7; /* jz 0x100a3ca7 */
            ii(0x100a_3c90, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_3c93, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3c96, 5); calld(0x1007_6574, -0x2_d727);          /* call 0x10076574 */
            ii(0x100a_3c9b, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100a_3c9e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_3ca3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_3ca5, 2); if(jgd(0x100a_3ca9, 0x2)) goto l_0x100a_3ca9; /* jg 0x100a3ca9 */
        l_0x100a_3ca7:
            ii(0x100a_3ca7, 2); jmpd(0x100a_3cd5, 0x2c); goto l_0x100a_3cd5; /* jmp 0x100a3cd5 */
        l_0x100a_3ca9:
            ii(0x100a_3ca9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_3cac, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3caf, 5); calld(0x1007_6574, -0x2_d740);          /* call 0x10076574 */
            ii(0x100a_3cb4, 5); calld(0x1015_26ac, 0xa_e9f3);           /* call 0x101526ac */
            ii(0x100a_3cb9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3cbc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3cbf, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100a_3cc2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_3cc5, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3cc8, 5); calld(0x1007_65d0, -0x2_d6fd);          /* call 0x100765d0 */
            ii(0x100a_3ccd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_3ccf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3cd2, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
        l_0x100a_3cd5:
            ii(0x100a_3cd5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3cd7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_3cd8, 1); popd(edi);                              /* pop edi */
            ii(0x100a_3cd9, 1); popd(esi);                              /* pop esi */
            ii(0x100a_3cda, 1); popd(edx);                              /* pop edx */
            ii(0x100a_3cdb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_3cdc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_3cdd, 1); retd(); return;                         /* ret */
        }
    }
}
