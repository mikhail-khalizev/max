using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("459f8772-5aac-470a-82d8-179cc3798194")]
        public void /* sys */ Method_1017_dc61()
        {
            ii(0x1017_dc61, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_dc62, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_dc63, 1); pushd(edx);                             /* push edx */
            ii(0x1017_dc64, 1); pushd(esi);                             /* push esi */
            ii(0x1017_dc65, 1); pushd(edi);                             /* push edi */
            ii(0x1017_dc66, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_dc67, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_dc69, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1017_dc6f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1017_dc72, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1017_dc79, 4); imul(eax, memd_a32[ss, ebp - 0x10], 0x6); /* imul eax, [ebp-0x10], 0x6 */
            ii(0x1017_dc7d, 9); mov(memw_a32[ds, eax + 0x101c_069d], 0); /* mov word [eax+0x101c069d], 0x0 */
            ii(0x1017_dc86, 10); mov(memd_a32[ds, eax + 0x101c_0699], 0); /* mov dword [eax+0x101c0699], 0x0 */
            ii(0x1017_dc90, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1017_dc97:
            ii(0x1017_dc97, 4); cmp(memd_a32[ss, ebp - 0x4], 0x10);     /* cmp dword [ebp-0x4], 0x10 */
            ii(0x1017_dc9b, 2); if(jbd(0x1017_dca4, 0x7)) goto l_0x1017_dca4; /* jb 0x1017dca4 */
            ii(0x1017_dc9d, 2); jmpd(0x1017_dcf1, 0x52); goto l_0x1017_dcf1; /* jmp 0x1017dcf1 */
        l_0x1017_dc9f:
            ii(0x1017_dc9f, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
            ii(0x1017_dca2, 2); jmpd(0x1017_dc97, -0xd); goto l_0x1017_dc97; /* jmp 0x1017dc97 */
        l_0x1017_dca4:
            ii(0x1017_dca4, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x6); /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1017_dca8, 7); cmp(memd_a32[ds, eax + 0x101c_0699], 0); /* cmp dword [eax+0x101c0699], 0x0 */
            ii(0x1017_dcaf, 2); if(jnzd(0x1017_dcbb, 0xa)) goto l_0x1017_dcbb; /* jnz 0x1017dcbb */
            ii(0x1017_dcb1, 8); cmp(memw_a32[ds, eax + 0x101c_069d], 0); /* cmp word [eax+0x101c069d], 0x0 */
            ii(0x1017_dcb9, 2); if(jzd(0x1017_dcef, 0x34)) goto l_0x1017_dcef; /* jz 0x1017dcef */
        l_0x1017_dcbb:
            ii(0x1017_dcbb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_dcbe, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_dcc1, 6); mov(eax, memd_a32[ds, eax + 0x101c_06f9]); /* mov eax, [eax+0x101c06f9] */
            ii(0x1017_dcc7, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1017_dcca, 2); if(jbed(0x1017_dcde, 0x12)) goto l_0x1017_dcde; /* jbe 0x1017dcde */
            ii(0x1017_dccc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_dccf, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_dcd2, 10); cmp(memd_a32[ds, eax + 0x101c_06f9], 0xff00); /* cmp dword [eax+0x101c06f9], 0xff00 */
            ii(0x1017_dcdc, 2); if(jnzd(0x1017_dce0, 0x2)) goto l_0x1017_dce0; /* jnz 0x1017dce0 */
        l_0x1017_dcde:
            ii(0x1017_dcde, 2); jmpd(0x1017_dcef, 0xf); goto l_0x1017_dcef; /* jmp 0x1017dcef */
        l_0x1017_dce0:
            ii(0x1017_dce0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_dce3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_dce6, 6); mov(eax, memd_a32[ds, eax + 0x101c_06f9]); /* mov eax, [eax+0x101c06f9] */
            ii(0x1017_dcec, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1017_dcef:
            ii(0x1017_dcef, 2); jmpd(0x1017_dc9f, -0x52); goto l_0x1017_dc9f; /* jmp 0x1017dc9f */
        l_0x1017_dcf1:
            ii(0x1017_dcf1, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1017_dcf5, 2); if(jzd(0x1017_dd08, 0x11)) goto l_0x1017_dd08; /* jz 0x1017dd08 */
            ii(0x1017_dcf7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_dcf9, 5); mov(eax, 0x12_34dc);                    /* mov eax, 0x1234dc */
            ii(0x1017_dcfe, 3); div(memd_a32[ss, ebp - 0x8]);           /* div dword [ebp-0x8] */
            ii(0x1017_dd01, 5); calld(/* sys */ 0x1017_de3a, 0x134);    /* call 0x1017de3a */
            ii(0x1017_dd06, 2); jmpd(0x1017_dd12, 0xa); goto l_0x1017_dd12; /* jmp 0x1017dd12 */
        l_0x1017_dd08:
            ii(0x1017_dd08, 5); mov(eax, 0xffff);                       /* mov eax, 0xffff */
            ii(0x1017_dd0d, 5); calld(/* sys */ 0x1017_de3a, 0x128);    /* call 0x1017de3a */
        l_0x1017_dd12:
            ii(0x1017_dd12, 7); cmp(memb_a32[ds, 0x101c_1a54], 0);      /* cmp byte [0x101c1a54], 0x0 */
            ii(0x1017_dd19, 2); if(jzd(0x1017_dd20, 0x5)) goto l_0x1017_dd20; /* jz 0x1017dd20 */
            ii(0x1017_dd1b, 5); calld(/* sys */ 0x1019_4b45, 0x16e25);  /* call 0x10194b45 */
        l_0x1017_dd20:
            ii(0x1017_dd20, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1017_dd27:
            ii(0x1017_dd27, 4); cmp(memd_a32[ss, ebp - 0x4], 0x10);     /* cmp dword [ebp-0x4], 0x10 */
            ii(0x1017_dd2b, 2); if(jbd(0x1017_dd37, 0xa)) goto l_0x1017_dd37; /* jb 0x1017dd37 */
            ii(0x1017_dd2d, 5); jmpd(0x1017_ddf1, 0xbf); goto l_0x1017_ddf1; /* jmp 0x1017ddf1 */
        l_0x1017_dd32:
            ii(0x1017_dd32, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
            ii(0x1017_dd35, 2); jmpd(0x1017_dd27, -0x10); goto l_0x1017_dd27; /* jmp 0x1017dd27 */
        l_0x1017_dd37:
            ii(0x1017_dd37, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x6); /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1017_dd3b, 7); cmp(memd_a32[ds, eax + 0x101c_0699], 0); /* cmp dword [eax+0x101c0699], 0x0 */
            ii(0x1017_dd42, 2); if(jnzd(0x1017_dd52, 0xe)) goto l_0x1017_dd52; /* jnz 0x1017dd52 */
            ii(0x1017_dd44, 8); cmp(memw_a32[ds, eax + 0x101c_069d], 0); /* cmp word [eax+0x101c069d], 0x0 */
            ii(0x1017_dd4c, 6); if(jzd(0x1017_ddec, 0x9a)) goto l_0x1017_ddec; /* jz 0x1017ddec */
        l_0x1017_dd52:
            ii(0x1017_dd52, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_dd55, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_dd58, 10); cmp(memd_a32[ds, eax + 0x101c_06f9], 0xff00); /* cmp dword [eax+0x101c06f9], 0xff00 */
            ii(0x1017_dd62, 2); if(jnzd(0x1017_ddaa, 0x46)) goto l_0x1017_ddaa; /* jnz 0x1017ddaa */
            ii(0x1017_dd64, 10); cmp(memd_a32[ds, 0x101c_0695], 0xffff); /* cmp dword [0x101c0695], 0xffff */
            ii(0x1017_dd6e, 2); if(jnzd(0x1017_dd82, 0x12)) goto l_0x1017_dd82; /* jnz 0x1017dd82 */
            ii(0x1017_dd70, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_dd73, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_dd76, 10); mov(memd_a32[ds, eax + 0x101c_0739], 0x1_0000); /* mov dword [eax+0x101c0739], 0x10000 */
            ii(0x1017_dd80, 2); jmpd(0x1017_dda8, 0x26); goto l_0x1017_dda8; /* jmp 0x1017dda8 */
        l_0x1017_dd82:
            ii(0x1017_dd82, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_dd84, 5); mov(eax, 0x12_34dc);                    /* mov eax, 0x1234dc */
            ii(0x1017_dd89, 6); div(memd_a32[ds, 0x101c_0695]);         /* div dword [0x101c0695] */
            ii(0x1017_dd8f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_dd91, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_dd93, 5); mov(eax, 0x12_3333);                    /* mov eax, 0x123333 */
            ii(0x1017_dd98, 2); div(ebx);                               /* div ebx */
            ii(0x1017_dd9a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_dd9c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_dd9f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_dda2, 6); mov(memd_a32[ds, eax + 0x101c_0739], ebx); /* mov [eax+0x101c0739], ebx */
        l_0x1017_dda8:
            ii(0x1017_dda8, 2); jmpd(0x1017_dddc, 0x32); goto l_0x1017_dddc; /* jmp 0x1017dddc */
        l_0x1017_ddaa:
            ii(0x1017_ddaa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_ddad, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_ddb0, 6); mov(ecx, memd_a32[ds, eax + 0x101c_06f9]); /* mov ecx, [eax+0x101c06f9] */
            ii(0x1017_ddb6, 3); shl(ecx, 0x10);                         /* shl ecx, 0x10 */
            ii(0x1017_ddb9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_ddbb, 5); mov(eax, 0x12_34dc);                    /* mov eax, 0x1234dc */
            ii(0x1017_ddc0, 6); div(memd_a32[ds, 0x101c_0695]);         /* div dword [0x101c0695] */
            ii(0x1017_ddc6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_ddc8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_ddca, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_ddcc, 2); div(ebx);                               /* div ebx */
            ii(0x1017_ddce, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_ddd0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_ddd3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_ddd6, 6); mov(memd_a32[ds, eax + 0x101c_0739], ebx); /* mov [eax+0x101c0739], ebx */
        l_0x1017_dddc:
            ii(0x1017_dddc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_dddf, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_dde2, 10); mov(memd_a32[ds, eax + 0x101c_0779], 0); /* mov dword [eax+0x101c0779], 0x0 */
        l_0x1017_ddec:
            ii(0x1017_ddec, 5); jmpd(0x1017_dd32, -0xbf); goto l_0x1017_dd32; /* jmp 0x1017dd32 */
        l_0x1017_ddf1:
            ii(0x1017_ddf1, 7); cmp(memb_a32[ds, 0x101c_1a54], 0);      /* cmp byte [0x101c1a54], 0x0 */
            ii(0x1017_ddf8, 2); if(jzd(0x1017_ddff, 0x5)) goto l_0x1017_ddff; /* jz 0x1017ddff */
            ii(0x1017_ddfa, 5); calld(/* sys */ 0x1019_4b71, 0x16d72);  /* call 0x10194b71 */
        l_0x1017_ddff:
            ii(0x1017_ddff, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1017_de06, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1017_de09, 1); leaved();                               /* leave */
            ii(0x1017_de0a, 1); popd(edi);                              /* pop edi */
            ii(0x1017_de0b, 1); popd(esi);                              /* pop esi */
            ii(0x1017_de0c, 1); popd(edx);                              /* pop edx */
            ii(0x1017_de0d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_de0e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_de0f, 1); retd(); return;                         /* ret */
        }
    }
}
