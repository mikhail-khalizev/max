using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_3d48-d155b095")]
        public void Method_1007_3d48()
        {
            ii(0x1007_3d48, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_3d4d, 5); calld(Definitions.sys_check_available_stack_size, 0xf_2000); /* call 0x10165d52 */
            ii(0x1007_3d52, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_3d53, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_3d54, 1); pushd(esi);                             /* push esi */
            ii(0x1007_3d55, 1); pushd(edi);                             /* push edi */
            ii(0x1007_3d56, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_3d57, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_3d59, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_3d5f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_3d62, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_3d65, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_3d69, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_3d6d, 5); calld(0x1007_3cfd, -0x75);              /* call 0x10073cfd */
            ii(0x1007_3d72, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_3d75, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_3d77, 4); mov(ax, memw_a32[ss, ebp - 0xc]);       /* mov ax, [ebp-0xc] */
            ii(0x1007_3d7b, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_3d7e, 2); if(jzd(0x1007_3d8b, 0xb)) goto l_0x1007_3d8b; /* jz 0x10073d8b */
            ii(0x1007_3d80, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_3d82, 4); mov(ax, memw_a32[ss, ebp - 0xc]);       /* mov ax, [ebp-0xc] */
            ii(0x1007_3d86, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1007_3d89, 2); if(jnzd(0x1007_3df0, 0x65)) goto l_0x1007_3df0; /* jnz 0x10073df0 */
        l_0x1007_3d8b:
            ii(0x1007_3d8b, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_3d8f, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_3d93, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_3d98, 5); calld(0x1010_3541, 0x8_f7a4);           /* call 0x10103541 */
            ii(0x1007_3d9d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_3d9f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_3da2, 5); calld(0x1007_64b8, 0x2711);             /* call 0x100764b8 */
        l_0x1007_3da7:
            ii(0x1007_3da7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3da9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_3dac, 5); calld(0x1013_ad71, 0xc_6fc0);           /* call 0x1013ad71 */
            ii(0x1007_3db1, 2); test(al, al);                           /* test al, al */
            ii(0x1007_3db3, 2); if(jzd(0x1007_3de6, 0x31)) goto l_0x1007_3de6; /* jz 0x10073de6 */
            ii(0x1007_3db5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_3db8, 5); calld(0x1007_63a0, 0x25e3);             /* call 0x100763a0 */
            ii(0x1007_3dbd, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x1007_3dc2, 2); if(jzd(0x1007_3dd3, 0xf)) goto l_0x1007_3dd3; /* jz 0x10073dd3 */
            ii(0x1007_3dc4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_3dc7, 5); calld(0x1007_63a0, 0x25d4);             /* call 0x100763a0 */
            ii(0x1007_3dcc, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1007_3dd1, 2); if(jnzd(0x1007_3ddc, 0x9)) goto l_0x1007_3ddc; /* jnz 0x10073ddc */
        l_0x1007_3dd3:
            ii(0x1007_3dd3, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x1007_3dda, 2); jmpd(0x1007_3de6, 0xa); goto l_0x1007_3de6; /* jmp 0x10073de6 */
        l_0x1007_3ddc:
            ii(0x1007_3ddc, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_3ddf, 5); calld(0x1007_6bf8, 0x2e14);             /* call 0x10076bf8 */
            ii(0x1007_3de4, 2); jmpd(0x1007_3da7, -0x3f); goto l_0x1007_3da7; /* jmp 0x10073da7 */
        l_0x1007_3de6:
            ii(0x1007_3de6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3de8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_3deb, 5); calld(0x1007_5f6c, 0x217c);             /* call 0x10075f6c */
        l_0x1007_3df0:
            ii(0x1007_3df0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_3df3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_3df6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_3df9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_3dfb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_3dfc, 1); popd(edi);                              /* pop edi */
            ii(0x1007_3dfd, 1); popd(esi);                              /* pop esi */
            ii(0x1007_3dfe, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_3dff, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_3e00, 1); retd();                                 /* ret */
        }
    }
}
