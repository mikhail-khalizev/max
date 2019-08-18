using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("21141b03-fd5c-43d6-929b-17f59fe81c5e")]
        public void /* sys */ Method_1019_5535()
        {
            ii(0x1019_5535, 1); pushd(esi);                             /* push esi */
            ii(0x1019_5536, 1); pushd(edi);                             /* push edi */
            ii(0x1019_5537, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_5538, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_553a, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1019_5540, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1019_5543, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x1019_5546, 4); mov(memw_a32[ss, ebp - 0x30], cx);      /* mov [ebp-0x30], cx */
            ii(0x1019_554a, 3); mov(memd_a32[ss, ebp - 0x34], ebx);     /* mov [ebp-0x34], ebx */
            ii(0x1019_554d, 7); mov(memd_a32[ss, ebp - 0xc], 0x2c);     /* mov dword [ebp-0xc], 0x2c */
            ii(0x1019_5554, 7); mov(memd_a32[ss, ebp - 0x10], 0x30);    /* mov dword [ebp-0x10], 0x30 */
            ii(0x1019_555b, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1019_5562, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1019_5569, 4); cmp(memd_a32[ss, ebp - 0x20], 0x5);     /* cmp dword [ebp-0x20], 0x5 */
            ii(0x1019_556d, 2); if(jbed(0x1019_557b, 0xc)) goto l_0x1019_557b; /* jbe 0x1019557b */
            ii(0x1019_556f, 7); mov(memd_a32[ss, ebp - 0x2c], 0xa);     /* mov dword [ebp-0x2c], 0xa */
            ii(0x1019_5576, 5); jmpd(0x1019_571d, 0x1a2); goto l_0x1019_571d; /* jmp 0x1019571d */
        l_0x1019_557b:
            ii(0x1019_557b, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1019_557e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_5581, 7); cmp(memd_a32[ds, eax + 0x101c_02b0], 0); /* cmp dword [eax+0x101c02b0], 0x0 */
            ii(0x1019_5588, 2); if(jzd(0x1019_5596, 0xc)) goto l_0x1019_5596; /* jz 0x10195596 */
            ii(0x1019_558a, 7); mov(memd_a32[ss, ebp - 0x2c], 0x9);     /* mov dword [ebp-0x2c], 0x9 */
            ii(0x1019_5591, 5); jmpd(0x1019_571d, 0x187); goto l_0x1019_571d; /* jmp 0x1019571d */
        l_0x1019_5596:
            ii(0x1019_5596, 7); cmp(memd_a32[ss, ebp - 0x24], 0xe000);  /* cmp dword [ebp-0x24], 0xe000 */
            ii(0x1019_559d, 2); if(jbd(0x1019_55a8, 0x9)) goto l_0x1019_55a8; /* jb 0x101955a8 */
            ii(0x1019_559f, 7); cmp(memd_a32[ss, ebp - 0x24], 0xe200);  /* cmp dword [ebp-0x24], 0xe200 */
            ii(0x1019_55a6, 2); if(jbed(0x1019_55b4, 0xc)) goto l_0x1019_55b4; /* jbe 0x101955b4 */
        l_0x1019_55a8:
            ii(0x1019_55a8, 7); mov(memd_a32[ss, ebp - 0x2c], 0x6);     /* mov dword [ebp-0x2c], 0x6 */
            ii(0x1019_55af, 5); jmpd(0x1019_571d, 0x169); goto l_0x1019_571d; /* jmp 0x1019571d */
        l_0x1019_55b4:
            ii(0x1019_55b4, 5); mov(edx, 0x101c_07ca);                  /* mov edx, 0x101c07ca */
            ii(0x1019_55b9, 5); mov(eax, 0x101c_08c9);                  /* mov eax, 0x101c08c9 */
            ii(0x1019_55be, 5); calld(Definitions.sys_strcpy, -0x2_f6f4); /* call 0x10165ecf */
            ii(0x1019_55c3, 5); mov(edx, StringDefinitions.Hmidrv386);  /* mov edx, 0x101b3458 */
            ii(0x1019_55c8, 5); mov(eax, 0x101c_08c9);                  /* mov eax, 0x101c08c9 */
            ii(0x1019_55cd, 5); calld(Definitions.sys_strcat, -0x2_f6a1); /* call 0x10165f31 */
            ii(0x1019_55d2, 5); pushd(0x200);                           /* push 0x200 */
            ii(0x1019_55d7, 5); mov(eax, 0x101c_08c9);                  /* mov eax, 0x101c08c9 */
            ii(0x1019_55dc, 1); pushd(eax);                             /* push eax */
            ii(0x1019_55dd, 5); calld(/* sys */ 0x1017_cf25, -0x1_86bd); /* call 0x1017cf25 */
            ii(0x1019_55e2, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_55e5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1019_55e8, 4); cmp(memd_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp dword [ebp-0x4], 0xffffffff */
            ii(0x1019_55ec, 2); if(jnzd(0x1019_55fa, 0xc)) goto l_0x1019_55fa; /* jnz 0x101955fa */
            ii(0x1019_55ee, 7); mov(memd_a32[ss, ebp - 0x2c], 0xf);     /* mov dword [ebp-0x2c], 0xf */
            ii(0x1019_55f5, 5); jmpd(0x1019_571d, 0x123); goto l_0x1019_571d; /* jmp 0x1019571d */
        l_0x1019_55fa:
            ii(0x1019_55fa, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1019_55fd, 5); mov(edx, 0x1020_bc90);                  /* mov edx, 0x1020bc90 */
            ii(0x1019_5602, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_5605, 5); calld(/* sys */ 0x1017_d1fa, -0x1_8410); /* call 0x1017d1fa */
        l_0x1019_560a:
            ii(0x1019_560a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1019_560d, 6); cmp(eax, memd_a32[ds, 0x1020_bcb0]);    /* cmp eax, [0x1020bcb0] */
            ii(0x1019_5613, 2); if(jad(0x1019_561b, 0x6)) goto l_0x1019_561b; /* ja 0x1019561b */
            ii(0x1019_5615, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1019_5619, 2); if(jzd(0x1019_5620, 0x5)) goto l_0x1019_5620; /* jz 0x10195620 */
        l_0x1019_561b:
            ii(0x1019_561b, 5); jmpd(0x1019_56ec, 0xcc); goto l_0x1019_56ec; /* jmp 0x101956ec */
        l_0x1019_5620:
            ii(0x1019_5620, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1019_5623, 5); mov(edx, 0x1020_bc60);                  /* mov edx, 0x1020bc60 */
            ii(0x1019_5628, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_562b, 5); calld(/* sys */ 0x1017_d1fa, -0x1_8436); /* call 0x1017d1fa */
            ii(0x1019_5630, 5); mov(eax, memd_a32[ds, 0x1020_bc84]);    /* mov eax, [0x1020bc84] */
            ii(0x1019_5635, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1019_5638, 5); mov(eax, memd_a32[ds, 0x1020_bc88]);    /* mov eax, [0x1020bc88] */
            ii(0x1019_563d, 3); cmp(eax, memd_a32[ss, ebp - 0x24]);     /* cmp eax, [ebp-0x24] */
            ii(0x1019_5640, 2); if(jnzd(0x1019_564b, 0x9)) goto l_0x1019_564b; /* jnz 0x1019564b */
            ii(0x1019_5642, 7); test(memb_a32[ds, 0x1020_bc8d], 0x80);  /* test byte [0x1020bc8d], 0x80 */
            ii(0x1019_5649, 2); if(jnzd(0x1019_5650, 0x5)) goto l_0x1019_5650; /* jnz 0x10195650 */
        l_0x1019_564b:
            ii(0x1019_564b, 5); jmpd(0x1019_56d4, 0x84); goto l_0x1019_56d4; /* jmp 0x101956d4 */
        l_0x1019_5650:
            ii(0x1019_5650, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x1019_5657, 3); pushd(memd_a32[ss, ebp + 0x18]);        /* push dword [ebp+0x18] */
            ii(0x1019_565a, 3); pushd(memd_a32[ss, ebp - 0x8]);         /* push dword [ebp-0x8] */
            ii(0x1019_565d, 5); calld(/* sys */ 0x1019_4cb7, -0x9ab);   /* call 0x10194cb7 */
            ii(0x1019_5662, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_5664, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_5666, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_5669, 4); mov(memw_a32[ss, ebp - 0x38], bx);      /* mov [ebp-0x38], bx */
            ii(0x1019_566d, 3); mov(memd_a32[ss, ebp - 0x3c], ecx);     /* mov [ebp-0x3c], ecx */
            ii(0x1019_5670, 4); movzx(eax, memw_a32[ss, ebp - 0x38]);   /* movzx eax, word [ebp-0x38] */
            ii(0x1019_5674, 1); pushd(eax);                             /* push eax */
            ii(0x1019_5675, 3); pushd(memd_a32[ss, ebp - 0x3c]);        /* push dword [ebp-0x3c] */
            ii(0x1019_5678, 5); calld(/* sys */ 0x1019_4d7e, -0x8ff);   /* call 0x10194d7e */
            ii(0x1019_567d, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_567f, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_5681, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_5684, 4); mov(memw_a32[ss, ebp - 0x40], bx);      /* mov [ebp-0x40], bx */
            ii(0x1019_5688, 3); mov(memd_a32[ss, ebp - 0x44], ecx);     /* mov [ebp-0x44], ecx */
            ii(0x1019_568b, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1019_568e, 1); pushd(eax);                             /* push eax */
            ii(0x1019_568f, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x1019_5692, 3); mov(ebx, memd_a32[ss, ebp - 0x38]);     /* mov ebx, [ebp-0x38] */
            ii(0x1019_5695, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x1019_5698, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_569b, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1019_569d, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_569f, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1019_56a1, 5); calld(/* sys */ 0x1017_9414, -0x1_c292); /* call 0x10179414 */
            ii(0x1019_56a6, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1019_56a9, 4); lgs(edx, ss, ebp - 0x34);               /* lgs edx, [ebp-0x34] */
            ii(0x1019_56ad, 5); mov(memw_a32[gs, edx + 0x4], ax);       /* mov [gs:edx+0x4], ax */
            ii(0x1019_56b2, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1019_56b5, 4); lgs(edx, ss, ebp - 0x34);               /* lgs edx, [ebp-0x34] */
            ii(0x1019_56b9, 3); mov(memd_a32[gs, edx], eax);            /* mov [gs:edx], eax */
            ii(0x1019_56bc, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1019_56bf, 4); lgs(edx, ss, ebp + 0x10);               /* lgs edx, [ebp+0x10] */
            ii(0x1019_56c3, 5); mov(memw_a32[gs, edx + 0x4], ax);       /* mov [gs:edx+0x4], ax */
            ii(0x1019_56c8, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1019_56cb, 4); lgs(edx, ss, ebp + 0x10);               /* lgs edx, [ebp+0x10] */
            ii(0x1019_56cf, 3); mov(memd_a32[gs, edx], eax);            /* mov [gs:edx], eax */
            ii(0x1019_56d2, 2); jmpd(0x1019_56e4, 0x10); goto l_0x1019_56e4; /* jmp 0x101956e4 */
        l_0x1019_56d4:
            ii(0x1019_56d4, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1019_56d9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1019_56dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_56df, 5); calld(Definitions.sys_lseek, -0x1_854d); /* call 0x1017d197 */
        l_0x1019_56e4:
            ii(0x1019_56e4, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1019_56e7, 5); jmpd(0x1019_560a, -0xe2); goto l_0x1019_560a; /* jmp 0x1019560a */
        l_0x1019_56ec:
            ii(0x1019_56ec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_56ef, 5); calld(/* sys */ 0x1017_d1da, -0x1_851a); /* call 0x1017d1da */
            ii(0x1019_56f4, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1019_56f7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_56fa, 6); mov(edx, memd_a32[ds, 0x1020_bc88]);    /* mov edx, [0x1020bc88] */
            ii(0x1019_5700, 6); mov(memd_a32[ds, eax + 0x101c_035a], edx); /* mov [eax+0x101c035a], edx */
            ii(0x1019_5706, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1019_5709, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_570c, 10); mov(memd_a32[ds, eax + 0x101c_02b0], 0x1); /* mov dword [eax+0x101c02b0], 0x1 */
            ii(0x1019_5716, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
        l_0x1019_571d:
            ii(0x1019_571d, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1019_5720, 1); leaved();                               /* leave */
            ii(0x1019_5721, 1); popd(edi);                              /* pop edi */
            ii(0x1019_5722, 1); popd(esi);                              /* pop esi */
            ii(0x1019_5723, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
