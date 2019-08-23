using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_c44f-427e0b01")]
        public void Method_1007_c44f()
        {
            ii(0x1007_c44f, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1007_c454, 5); calld(Definitions.sys_check_available_stack_size, 0xe_98f9); /* call 0x10165d52 */
            ii(0x1007_c459, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_c45a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_c45b, 1); pushd(esi);                             /* push esi */
            ii(0x1007_c45c, 1); pushd(edi);                             /* push edi */
            ii(0x1007_c45d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_c45e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_c460, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1007_c466, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_c469, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_c46c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_c46e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_c471, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_c474, 5); calld(0x1013_ad11, 0xb_e898);           /* call 0x1013ad11 */
            ii(0x1007_c479, 2); test(al, al);                           /* test al, al */
            ii(0x1007_c47b, 2); if(jzd(0x1007_c4af, 0x32)) goto l_0x1007_c4af; /* jz 0x1007c4af */
            ii(0x1007_c47d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_c480, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_c483, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_c486, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1007_c489, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_c48c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_c48f, 3); calld_abs(memd_a32[ds, ebx + 0x54]);    /* call dword [ebx+0x54] */
            ii(0x1007_c492, 5); calld(0x1008_ac50, 0xe7b9);             /* call 0x1008ac50 */
            ii(0x1007_c497, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_c499, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_c49b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_c49e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c4a1, 5); calld(0x1015_2962, 0xd_64bc);           /* call 0x10152962 */
            ii(0x1007_c4a6, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_c4aa, 5); jmpd(0x1007_c596, 0xe7); goto l_0x1007_c596; /* jmp 0x1007c596 */
        l_0x1007_c4af:
            ii(0x1007_c4af, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_c4b2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c4b5, 5); calld(0x1015_2a52, 0xd_6598);           /* call 0x10152a52 */
            ii(0x1007_c4ba, 2); test(al, al);                           /* test al, al */
            ii(0x1007_c4bc, 2); if(jzd(0x1007_c4cd, 0xf)) goto l_0x1007_c4cd; /* jz 0x1007c4cd */
            ii(0x1007_c4be, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c4c1, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1007_c4c4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_c4c9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_c4cb, 2); if(jnzd(0x1007_c4d6, 0x9)) goto l_0x1007_c4d6; /* jnz 0x1007c4d6 */
        l_0x1007_c4cd:
            ii(0x1007_c4cd, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_c4d1, 5); jmpd(0x1007_c596, 0xc0); goto l_0x1007_c596; /* jmp 0x1007c596 */
        l_0x1007_c4d6:
            ii(0x1007_c4d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c4d9, 5); calld(0x1007_623c, -0x62a2);            /* call 0x1007623c */
            ii(0x1007_c4de, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1007_c4e1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_c4e4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_c4e6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_c4e9, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1007_c4ec, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1007_c4ee, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1007_c4f1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_c4f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c4f6, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1007_c4f9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_c4fe, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1007_c500, 2); if(jged(0x1007_c56e, 0x6c)) goto l_0x1007_c56e; /* jge 0x1007c56e */
            ii(0x1007_c502, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c505, 5); calld(0x1015_287d, 0xd_6373);           /* call 0x1015287d */
            ii(0x1007_c50a, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1007_c50f, 5); calld(Definitions.sys_new, 0xe_98ec);   /* call 0x10165e00 */
            ii(0x1007_c514, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_c517, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_c51a, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_c51d, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1007_c521, 2); if(jzd(0x1007_c539, 0x16)) goto l_0x1007_c539; /* jz 0x1007c539 */
            ii(0x1007_c523, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_c526, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_c529, 5); calld(Definitions.my_ctor_c15, 0x4_f35a); /* call 0x100cb888 */
            ii(0x1007_c52e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_c531, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_c534, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1007_c537, 2); jmpd(0x1007_c53f, 0x6); goto l_0x1007_c53f; /* jmp 0x1007c53f */
        l_0x1007_c539:
            ii(0x1007_c539, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_c53c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x1007_c53f:
            ii(0x1007_c53f, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1007_c542, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1007_c545, 5); calld(0x1008_b060, 0xeb16);             /* call 0x1008b060 */
            ii(0x1007_c54a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1007_c54d, 5); calld(0x1008_af84, 0xea32);             /* call 0x1008af84 */
            ii(0x1007_c552, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_c554, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_c559, 5); calld(0x100a_4d50, 0x2_87f2);           /* call 0x100a4d50 */
            ii(0x1007_c55e, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_c562, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_c564, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1007_c567, 5); calld(0x1008_8b7c, 0xc610);             /* call 0x10088b7c */
            ii(0x1007_c56c, 2); jmpd(0x1007_c596, 0x28); goto l_0x1007_c596; /* jmp 0x1007c596 */
        l_0x1007_c56e:
            ii(0x1007_c56e, 5); mov(ebx, 0x1007_c5a1);                  /* mov ebx, 0x1007c5a1 */
            ii(0x1007_c573, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_c576, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c579, 5); calld(0x1007_8d4a, -0x3834);            /* call 0x10078d4a */
            ii(0x1007_c57e, 2); test(al, al);                           /* test al, al */
            ii(0x1007_c580, 2); if(jnzd(0x1007_c592, 0x10)) goto l_0x1007_c592; /* jnz 0x1007c592 */
            ii(0x1007_c582, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_c585, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_c588, 5); calld(0x1007_c5f2, 0x65);               /* call 0x1007c5f2 */
            ii(0x1007_c58d, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1007_c590, 2); jmpd(0x1007_c596, 0x4); goto l_0x1007_c596; /* jmp 0x1007c596 */
        l_0x1007_c592:
            ii(0x1007_c592, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1007_c596:
            ii(0x1007_c596, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1007_c599, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_c59b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_c59c, 1); popd(edi);                              /* pop edi */
            ii(0x1007_c59d, 1); popd(esi);                              /* pop esi */
            ii(0x1007_c59e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_c59f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_c5a0, 1); retd();                                 /* ret */
        }
    }
}
