using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_0253-d39249f3")]
        public void Method_100f_0253()
        {
            ii(0x100f_0253, 5); pushd(0xa4);                            /* push 0xa4 */
            ii(0x100f_0258, 5); calld(Definitions.sys_check_available_stack_size, 0x7_5af5); /* call 0x10165d52 */
            ii(0x100f_025d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_025e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_025f, 1); pushd(edx);                             /* push edx */
            ii(0x100f_0260, 1); pushd(esi);                             /* push esi */
            ii(0x100f_0261, 1); pushd(edi);                             /* push edi */
            ii(0x100f_0262, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_0263, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_0265, 6); sub(esp, 0x88);                         /* sub esp, 0x88 */
            ii(0x100f_026b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_026e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0271, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x100f_0273, 5); mov(ebx, 0x80);                         /* mov ebx, 0x80 */
            ii(0x100f_0278, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_027d, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x100f_0283, 5); calld(Definitions.my_fread, -0xdf9);    /* call 0x100ef48f */
            ii(0x100f_0288, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_028a, 2); if(jnzd(0x100f_0295, 0x9)) goto l_0x100f_0295; /* jnz 0x100f0295 */
            ii(0x100f_028c, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_0290, 5); jmpd(0x100f_042d, 0x198); goto l_0x100f_042d; /* jmp 0x100f042d */
        l_0x100f_0295:
            ii(0x100f_0295, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_0297, 7); mov(ax, memw_a32[ss, ebp - 0x84]);      /* mov ax, [ebp-0x84] */
            ii(0x100f_029e, 5); cmp(eax, 0xaf12);                       /* cmp eax, 0xaf12 */
            ii(0x100f_02a3, 2); if(jzd(0x100f_02ae, 0x9)) goto l_0x100f_02ae; /* jz 0x100f02ae */
            ii(0x100f_02a5, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_02a9, 5); jmpd(0x100f_042d, 0x17f); goto l_0x100f_042d; /* jmp 0x100f042d */
        l_0x100f_02ae:
            ii(0x100f_02ae, 6); mov(eax, memd_a32[ss, ebp - 0x82]);     /* mov eax, [ebp-0x82] */
            ii(0x100f_02b4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_02b7, 4); mov(memw_a32[ds, edx + 0x61], ax);      /* mov [edx+0x61], ax */
            ii(0x100f_02bb, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x100f_02be, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_02c1, 4); mov(memw_a32[ds, edx + 0x63], ax);      /* mov [edx+0x63], ax */
            ii(0x100f_02c5, 3); mov(eax, memd_a32[ss, ebp - 0x7e]);     /* mov eax, [ebp-0x7e] */
            ii(0x100f_02c8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_02cb, 4); mov(memw_a32[ds, edx + 0x65], ax);      /* mov [edx+0x65], ax */
            ii(0x100f_02cf, 3); mov(eax, memd_a32[ss, ebp - 0x78]);     /* mov eax, [ebp-0x78] */
            ii(0x100f_02d2, 3); sar(eax, 0x3);                          /* sar eax, 0x3 */
            ii(0x100f_02d5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_02d8, 3); mov(memd_a32[ds, edx + 0x6b], eax);     /* mov [edx+0x6b], eax */
            ii(0x100f_02db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_02de, 3); mov(edx, memd_a32[ds, eax + 0x61]);     /* mov edx, [eax+0x61] */
            ii(0x100f_02e1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_02e4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_02e7, 3); add(edx, memd_a32[ds, eax + 0x50]);     /* add edx, [eax+0x50] */
            ii(0x100f_02ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_02ed, 1); dec(edx);                               /* dec edx */
            ii(0x100f_02ee, 3); mov(memd_a32[ds, eax + 0x58], edx);     /* mov [eax+0x58], edx */
            ii(0x100f_02f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_02f4, 3); mov(edx, memd_a32[ds, eax + 0x63]);     /* mov edx, [eax+0x63] */
            ii(0x100f_02f7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_02fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_02fd, 3); add(edx, memd_a32[ds, eax + 0x54]);     /* add edx, [eax+0x54] */
            ii(0x100f_0300, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0303, 1); dec(edx);                               /* dec edx */
            ii(0x100f_0304, 3); mov(memd_a32[ds, eax + 0x5c], edx);     /* mov [eax+0x5c], edx */
            ii(0x100f_0307, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_0309, 3); mov(edx, memd_a32[ss, ebp - 0x38]);     /* mov edx, [ebp-0x38] */
            ii(0x100f_030c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_030f, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_0311, 5); calld(Definitions.my_fseek, -0xec1);    /* call 0x100ef455 */
            ii(0x100f_0316, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_0319, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x100f_031c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_031f, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_0321, 5); calld(0x100f_008a, -0x29c);             /* call 0x100f008a */
            ii(0x100f_0326, 2); test(al, al);                           /* test al, al */
            ii(0x100f_0328, 2); if(jnzd(0x100f_0333, 0x9)) goto l_0x100f_0333; /* jnz 0x100f0333 */
            ii(0x100f_032a, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_032e, 5); jmpd(0x100f_042d, 0xfa); goto l_0x100f_042d; /* jmp 0x100f042d */
        l_0x100f_0333:
            ii(0x100f_0333, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0336, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_0338, 5); calld(Definitions.sys_ftell, 0x8_240a); /* call 0x10172747 */
            ii(0x100f_033d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_033f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0342, 3); mov(memd_a32[ds, eax + 0x44], edx);     /* mov [eax+0x44], edx */
            ii(0x100f_0345, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_0348, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_034b, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100f_034e, 5); calld(0x100e_fed0, -0x483);             /* call 0x100efed0 */
            ii(0x100f_0353, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0356, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100f_0359, 5); calld(Definitions.sys_free, 0x7_ad63);  /* call 0x1016b0c1 */
            ii(0x100f_035e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0361, 7); mov(memd_a32[ds, eax + 0x10], 0);       /* mov dword [eax+0x10], 0x0 */
            ii(0x100f_0368, 7); cmp(memb_a32[ds, 0x101c_4dcc], 0);      /* cmp byte [0x101c4dcc], 0x0 */
            ii(0x100f_036f, 2); if(jzd(0x100f_0384, 0x13)) goto l_0x100f_0384; /* jz 0x100f0384 */
            ii(0x100f_0371, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x100f_0376, 5); mov(eax, 0x101c_3f64);                  /* mov eax, 0x101c3f64 */
            ii(0x100f_037b, 5); calld(Definitions.sys_strcmp, 0x8_2410); /* call 0x10172790 */
            ii(0x100f_0380, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_0382, 2); if(jnzd(0x100f_0386, 0x2)) goto l_0x100f_0386; /* jnz 0x100f0386 */
        l_0x100f_0384:
            ii(0x100f_0384, 2); jmpd(0x100f_038f, 0x9); goto l_0x100f_038f; /* jmp 0x100f038f */
        l_0x100f_0386:
            ii(0x100f_0386, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0389, 6); mov(memw_a32[ds, eax + 0x61], 0x1);     /* mov word [eax+0x61], 0x1 */
        l_0x100f_038f:
            ii(0x100f_038f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0392, 3); mov(eax, memd_a32[ds, eax + 0x5f]);     /* mov eax, [eax+0x5f] */
            ii(0x100f_0395, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_0398, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_039b, 2); if(jled(0x100f_03a6, 0x9)) goto l_0x100f_03a6; /* jle 0x100f03a6 */
            ii(0x100f_039d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_03a0, 4); cmp(memb_a32[ds, eax + 0x60], 0);       /* cmp byte [eax+0x60], 0x0 */
            ii(0x100f_03a4, 2); if(jnzd(0x100f_03a8, 0x2)) goto l_0x100f_03a8; /* jnz 0x100f03a8 */
        l_0x100f_03a6:
            ii(0x100f_03a6, 2); jmpd(0x100f_0406, 0x5e); goto l_0x100f_0406; /* jmp 0x100f0406 */
        l_0x100f_03a8:
            ii(0x100f_03a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_03ab, 6); mov(memw_a32[ds, eax + 0x67], 0x1);     /* mov word [eax+0x67], 0x1 */
            ii(0x100f_03b1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_03b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_03b6, 3); mov(edx, memd_a32[ds, eax + 0x44]);     /* mov edx, [eax+0x44] */
            ii(0x100f_03b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_03bc, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_03be, 5); calld(Definitions.my_fseek, -0xf6e);    /* call 0x100ef455 */
            ii(0x100f_03c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_03c6, 5); calld(0x100f_01bb, -0x210);             /* call 0x100f01bb */
            ii(0x100f_03cb, 2); test(al, al);                           /* test al, al */
            ii(0x100f_03cd, 2); if(jnzd(0x100f_03d5, 0x6)) goto l_0x100f_03d5; /* jnz 0x100f03d5 */
            ii(0x100f_03cf, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_03d3, 2); jmpd(0x100f_042d, 0x58); goto l_0x100f_042d; /* jmp 0x100f042d */
        l_0x100f_03d5:
            ii(0x100f_03d5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_03d8, 6); mov(memw_a32[ds, eax + 0x67], 0);       /* mov word [eax+0x67], 0x0 */
            ii(0x100f_03de, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_03e1, 3); mov(eax, memd_a32[ds, eax + 0x5f]);     /* mov eax, [eax+0x5f] */
            ii(0x100f_03e4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_03e7, 1); dec(eax);                               /* dec eax */
            ii(0x100f_03e8, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x100f_03eb, 2); if(jad(0x100f_0400, 0x13)) goto l_0x100f_0400; /* ja 0x100f0400 */
            ii(0x100f_03ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_03f0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_03f2, 5); calld(Definitions.sys_fclose, 0x8_1c72); /* call 0x10172069 */
            ii(0x100f_03f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_03fa, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
        l_0x100f_0400:
            ii(0x100f_0400, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100f_0404, 2); jmpd(0x100f_042d, 0x27); goto l_0x100f_042d; /* jmp 0x100f042d */
        l_0x100f_0406:
            ii(0x100f_0406, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0409, 4); mov(memb_a32[ds, eax + 0x60], 0);       /* mov byte [eax+0x60], 0x0 */
            ii(0x100f_040d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0410, 6); mov(memw_a32[ds, eax + 0x61], 0);       /* mov word [eax+0x61], 0x0 */
            ii(0x100f_0416, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0419, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_041b, 5); calld(Definitions.sys_fclose, 0x8_1c49); /* call 0x10172069 */
            ii(0x100f_0420, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0423, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x100f_0429, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100f_042d:
            ii(0x100f_042d, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100f_0430, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_0432, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_0433, 1); popd(edi);                              /* pop edi */
            ii(0x100f_0434, 1); popd(esi);                              /* pop esi */
            ii(0x100f_0435, 1); popd(edx);                              /* pop edx */
            ii(0x100f_0436, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_0437, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_0438, 1); retd();                                 /* ret */
        }
    }
}
