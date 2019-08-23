using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_7e4d-e7377e3e")]
        public void Method_1015_7e4d()
        {
            ii(0x1015_7e4d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_7e52, 5); calld(Definitions.sys_check_available_stack_size, 0xdefb); /* call 0x10165d52 */
            ii(0x1015_7e57, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_7e58, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_7e59, 1); pushd(edx);                             /* push edx */
            ii(0x1015_7e5a, 1); pushd(esi);                             /* push esi */
            ii(0x1015_7e5b, 1); pushd(edi);                             /* push edi */
            ii(0x1015_7e5c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_7e5d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_7e5f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_7e65, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_7e68, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_7e6d, 5); calld(0x100f_448c, -0x6_39e6);          /* call 0x100f448c */
            ii(0x1015_7e72, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7e75, 4); cmp(memb_a32[ds, eax + 0x3e], 0x19);    /* cmp byte [eax+0x3e], 0x19 */
            ii(0x1015_7e79, 2); if(jnzd(0x1015_7e83, 0x8)) goto l_0x1015_7e83; /* jnz 0x10157e83 */
            ii(0x1015_7e7b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7e7e, 5); calld(0x100f_3f62, -0x6_3f21);          /* call 0x100f3f62 */
        l_0x1015_7e83:
            ii(0x1015_7e83, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7e86, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1015_7e8a, 2); if(jnzd(0x1015_7e95, 0x9)) goto l_0x1015_7e95; /* jnz 0x10157e95 */
            ii(0x1015_7e8c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7e8f, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1015_7e93, 2); if(jzd(0x1015_7e97, 0x2)) goto l_0x1015_7e97; /* jz 0x10157e97 */
        l_0x1015_7e95:
            ii(0x1015_7e95, 2); jmpd(0x1015_7e9e, 0x7); goto l_0x1015_7e9e; /* jmp 0x10157e9e */
        l_0x1015_7e97:
            ii(0x1015_7e97, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7e9a, 4); mov(memb_a32[ds, eax + 0x3e], 0x2);     /* mov byte [eax+0x3e], 0x2 */
        l_0x1015_7e9e:
            ii(0x1015_7e9e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_7ea0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7ea3, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_7ea6, 5); calld(0x1013_ad71, -0x1_d13a);          /* call 0x1013ad71 */
            ii(0x1015_7eab, 2); test(al, al);                           /* test al, al */
            ii(0x1015_7ead, 2); if(jzd(0x1015_7eb8, 0x9)) goto l_0x1015_7eb8; /* jz 0x10157eb8 */
            ii(0x1015_7eaf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7eb2, 4); cmp(memb_a32[ds, eax + 0x4e], 0);       /* cmp byte [eax+0x4e], 0x0 */
            ii(0x1015_7eb6, 2); if(jnzd(0x1015_7eba, 0x2)) goto l_0x1015_7eba; /* jnz 0x10157eba */
        l_0x1015_7eb8:
            ii(0x1015_7eb8, 2); jmpd(0x1015_7ec3, 0x9); goto l_0x1015_7ec3; /* jmp 0x10157ec3 */
        l_0x1015_7eba:
            ii(0x1015_7eba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7ebd, 4); cmp(memb_a32[ds, eax + 0x3d], 0xb);     /* cmp byte [eax+0x3d], 0xb */
            ii(0x1015_7ec1, 2); if(jnzd(0x1015_7ec5, 0x2)) goto l_0x1015_7ec5; /* jnz 0x10157ec5 */
        l_0x1015_7ec3:
            ii(0x1015_7ec3, 2); jmpd(0x1015_7ece, 0x9); goto l_0x1015_7ece; /* jmp 0x10157ece */
        l_0x1015_7ec5:
            ii(0x1015_7ec5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7ec8, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_7ecc, 2); if(jnzd(0x1015_7ed0, 0x2)) goto l_0x1015_7ed0; /* jnz 0x10157ed0 */
        l_0x1015_7ece:
            ii(0x1015_7ece, 2); jmpd(0x1015_7edc, 0xc); goto l_0x1015_7edc; /* jmp 0x10157edc */
        l_0x1015_7ed0:
            ii(0x1015_7ed0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7ed3, 5); calld(0x1007_61d4, -0xe_1d04);          /* call 0x100761d4 */
            ii(0x1015_7ed8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_7eda, 2); if(jzd(0x1015_7ede, 0x2)) goto l_0x1015_7ede; /* jz 0x10157ede */
        l_0x1015_7edc:
            ii(0x1015_7edc, 2); jmpd(0x1015_7f2a, 0x4c); goto l_0x1015_7f2a; /* jmp 0x10157f2a */
        l_0x1015_7ede:
            ii(0x1015_7ede, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7ee1, 3); mov(al, memb_a32[ds, eax + 0x3d]);      /* mov al, [eax+0x3d] */
            ii(0x1015_7ee4, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1015_7ee7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7eea, 3); mov(dl, memb_a32[ds, eax + 0x3f]);      /* mov dl, [eax+0x3f] */
            ii(0x1015_7eed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7ef0, 3); mov(memb_a32[ds, eax + 0x3d], dl);      /* mov [eax+0x3d], dl */
            ii(0x1015_7ef3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7ef6, 3); mov(dl, memb_a32[ds, eax + 0x40]);      /* mov dl, [eax+0x40] */
            ii(0x1015_7ef9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7efc, 3); mov(memb_a32[ds, eax + 0x3e], dl);      /* mov [eax+0x3e], dl */
            ii(0x1015_7eff, 4); cmp(memb_a32[ss, ebp - 0x8], 0x1e);     /* cmp byte [ebp-0x8], 0x1e */
            ii(0x1015_7f03, 2); if(jnzd(0x1015_7f16, 0x11)) goto l_0x1015_7f16; /* jnz 0x10157f16 */
            ii(0x1015_7f05, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_7f07, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1015_7f0c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7f0f, 5); calld(0x1016_3053, 0xb13f);             /* call 0x10163053 */
            ii(0x1015_7f14, 2); jmpd(0x1015_7f25, 0xf); goto l_0x1015_7f25; /* jmp 0x10157f25 */
        l_0x1015_7f16:
            ii(0x1015_7f16, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_7f18, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1015_7f1d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7f20, 5); calld(0x1016_3053, 0xb12e);             /* call 0x10163053 */
        l_0x1015_7f25:
            ii(0x1015_7f25, 5); calld(0x100f_f5c1, -0x5_8969);          /* call 0x100ff5c1 */
        l_0x1015_7f2a:
            ii(0x1015_7f2a, 5); mov(eax, 0x57);                         /* mov eax, 0x57 */
            ii(0x1015_7f2f, 5); calld(0x1007_5fdc, -0xe_1f58);          /* call 0x10075fdc */
            ii(0x1015_7f34, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_7f36, 2); if(jzd(0x1015_7f42, 0xa)) goto l_0x1015_7f42; /* jz 0x10157f42 */
            ii(0x1015_7f38, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_7f3d, 5); calld(0x1010_1374, -0x5_6bce);          /* call 0x10101374 */
        l_0x1015_7f42:
            ii(0x1015_7f42, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_7f44, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_7f45, 1); popd(edi);                              /* pop edi */
            ii(0x1015_7f46, 1); popd(esi);                              /* pop esi */
            ii(0x1015_7f47, 1); popd(edx);                              /* pop edx */
            ii(0x1015_7f48, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_7f49, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_7f4a, 1); retd();                                 /* ret */
        }
    }
}
