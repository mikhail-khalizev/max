using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_5227-d0503500")]
        public void Method_100f_5227()
        {
            ii(0x100f_5227, 5); push(0x10c);                            /* push 0x10c */
            ii(0x100f_522c, 5); call(Definitions.sys_check_available_stack_size, 0x7_0b21); /* call 0x10165d52 */
            ii(0x100f_5231, 1); push(ebx);                              /* push ebx */
            ii(0x100f_5232, 1); push(ecx);                              /* push ecx */
            ii(0x100f_5233, 1); push(edx);                              /* push edx */
            ii(0x100f_5234, 1); push(esi);                              /* push esi */
            ii(0x100f_5235, 1); push(edi);                              /* push edi */
            ii(0x100f_5236, 1); push(ebp);                              /* push ebp */
            ii(0x100f_5237, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_5239, 6); sub(esp, 0xdc);                         /* sub esp, 0xdc */
            ii(0x100f_523f, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x100f_5242, 5); mov(eax, memd[ds, 0x101c_711e]);        /* mov eax, [0x101c711e] */
            ii(0x100f_5247, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_524a, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x100f_524d, 2); if(jnz(0x100f_5260, 0x11)) goto l_0x100f_5260; /* jnz 0x100f5260 */
            ii(0x100f_524f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5251, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_5253, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100f_5256, 5); call(0x100f_4ebe, -0x39d);              /* call 0x100f4ebe */
            ii(0x100f_525b, 5); jmp(0x100f_53be, 0x15e); goto l_0x100f_53be; /* jmp 0x100f53be */
        l_0x100f_5260:
            ii(0x100f_5260, 5); call(0x1013_9c10, 0x4_49ab);            /* call 0x10139c10 */
            ii(0x100f_5265, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100f_5268, 4); movsx(ebx, memb[ss, ebp - 8]);          /* movsx ebx, byte [ebp-0x8] */
            ii(0x100f_526c, 3); shl(ebx, 2);                            /* shl ebx, 0x2 */
            ii(0x100f_526f, 6); push(memd[ds, ebx + 0x101b_d42c]);      /* push dword [ebx+0x101bd42c] */
            ii(0x100f_5275, 5); mov(eax, memd[ds, 0x101c_711e]);        /* mov eax, [0x101c711e] */
            ii(0x100f_527a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_527d, 1); push(eax);                              /* push eax */
            ii(0x100f_527e, 5); mov(eax, StringDefinitions.SaveIS4);    /* mov eax, 0x101a256c */
            ii(0x100f_5283, 1); push(eax);                              /* push eax */
            ii(0x100f_5284, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100f_5287, 1); push(eax);                              /* push eax */
            ii(0x100f_5288, 5); call(Definitions.sys_sprintf, 0x7_0c74); /* call 0x10165f01 */
            ii(0x100f_528d, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100f_5290, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_5292, 6); lea(ebx, memd[ss, ebp - 200]);          /* lea ebx, [ebp-0xc8] */
            ii(0x100f_5298, 5); movsx(ax, memb[ss, ebp - 8]);           /* movsx ax, byte [ebp-0x8] */
            ii(0x100f_529d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_52a0, 5); mov(eax, memd[ds, 0x101c_711e]);        /* mov eax, [0x101c711e] */
            ii(0x100f_52a5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_52a8, 5); call(0x1013_9ade, 0x4_4831);            /* call 0x10139ade */
            ii(0x100f_52ad, 7); or(memb[ss, ebp - 204], 1);             /* or byte [ebp-0xcc], 0x1 */
            ii(0x100f_52b4, 6); lea(eax, memd[ss, ebp - 208]);          /* lea eax, [ebp-0xd0] */
            ii(0x100f_52ba, 5); call(Definitions.my_string_ctor, 0x4_c829); /* call 0x10141ae8 */
            ii(0x100f_52bf, 6); mov(memd[ss, ebp - 212], eax);          /* mov [ebp-0xd4], eax */
            ii(0x100f_52c5, 7); and(memb[ss, ebp - 204], -2 /* 0xfe */); /* and byte [ebp-0xcc], 0xfe */
            ii(0x100f_52cc, 6); lea(eax, memd[ss, ebp - 197]);          /* lea eax, [ebp-0xc5] */
            ii(0x100f_52d2, 1); push(eax);                              /* push eax */
            ii(0x100f_52d3, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100f_52d6, 1); push(eax);                              /* push eax */
            ii(0x100f_52d7, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_52db, 2); if(jz(0x100f_52e9, 0xc)) goto l_0x100f_52e9; /* jz 0x100f52e9 */
            ii(0x100f_52dd, 10); mov(memd[ss, ebp - 216], StringDefinitions.OkToSaveFileSS); /* mov dword [ebp-0xd8], 0x101a2576 */
            ii(0x100f_52e7, 2); jmp(0x100f_52f3, 0xa); goto l_0x100f_52f3; /* jmp 0x100f52f3 */
        l_0x100f_52e9:
            ii(0x100f_52e9, 10); mov(memd[ss, ebp - 216], StringDefinitions.OkToLoadFileSS); /* mov dword [ebp-0xd8], 0x101a258f */
        l_0x100f_52f3:
            ii(0x100f_52f3, 6); push(memd[ss, ebp - 216]);              /* push dword [ebp-0xd8] */
            ii(0x100f_52f9, 5); mov(eax, 0xc8);                         /* mov eax, 0xc8 */
            ii(0x100f_52fe, 1); push(eax);                              /* push eax */
            ii(0x100f_52ff, 6); lea(eax, memd[ss, ebp - 208]);          /* lea eax, [ebp-0xd0] */
            ii(0x100f_5305, 1); push(eax);                              /* push eax */
            ii(0x100f_5306, 5); call(0x1014_2037, 0x4_cd2c);            /* call 0x10142037 */
            ii(0x100f_530b, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x100f_530e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5310, 6); lea(eax, memd[ss, ebp - 208]);          /* lea eax, [ebp-0xd0] */
            ii(0x100f_5316, 5); call(Definitions.my_strobj_c_str_v2, -0x6_bb53); /* call 0x100897c8 */
            ii(0x100f_531b, 5); call(0x1011_7036, 0x2_1d16);            /* call 0x10117036 */
            ii(0x100f_5320, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_5322, 2); if(jnz(0x100f_5336, 0x12)) goto l_0x100f_5336; /* jnz 0x100f5336 */
            ii(0x100f_5324, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5326, 6); lea(eax, memd[ss, ebp - 208]);          /* lea eax, [ebp-0xd0] */
            ii(0x100f_532c, 5); call(Definitions.my_string_dtor, 0x4_c7f9); /* call 0x10141b2a */
            ii(0x100f_5331, 5); jmp(0x100f_53be, 0x88); goto l_0x100f_53be; /* jmp 0x100f53be */
        l_0x100f_5336:
            ii(0x100f_5336, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_533a, 2); if(jz(0x100f_538b, 0x4f)) goto l_0x100f_538b; /* jz 0x100f538b */
            ii(0x100f_533c, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_5343, 2); if(jz(0x100f_5353, 0xe)) goto l_0x100f_5353; /* jz 0x100f5353 */
            ii(0x100f_5345, 6); lea(edx, memd[ss, ebp - 197]);          /* lea edx, [ebp-0xc5] */
            ii(0x100f_534b, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100f_534e, 5); call(0x1012_9155, 0x3_3e02);            /* call 0x10129155 */
        l_0x100f_5353:
            ii(0x100f_5353, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100f_5358, 6); lea(edx, memd[ss, ebp - 197]);          /* lea edx, [ebp-0xc5] */
            ii(0x100f_535e, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100f_5361, 5); call(0x1013_6e81, 0x4_1b1b);            /* call 0x10136e81 */
            ii(0x100f_5366, 5); call(0x100c_aa00, -0x2_a96b);           /* call 0x100caa00 */
            ii(0x100f_536b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_5370, 1); push(eax);                              /* push eax */
            ii(0x100f_5371, 5); call(0x100c_aa20, -0x2_a956);           /* call 0x100caa20 */
            ii(0x100f_5376, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_5378, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_537a, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100f_537f, 5); mov(eax, StringDefinitions.GameSaved);  /* mov eax, 0x101a25a8 */
            ii(0x100f_5384, 5); call(0x1011_5d23, 0x2_099a);            /* call 0x10115d23 */
            ii(0x100f_5389, 2); jmp(0x100f_53b1, 0x26); goto l_0x100f_53b1; /* jmp 0x100f53b1 */
        l_0x100f_538b:
            ii(0x100f_538b, 5); call(0x100e_f348, -0x6048);             /* call 0x100ef348 */
            ii(0x100f_5390, 1); cwde();                                 /* cwde */
            ii(0x100f_5391, 5); call(0x100f_3499, -0x1efd);             /* call 0x100f3499 */
            ii(0x100f_5396, 6); mov(memd[ss, ebp - 220], eax);          /* mov [ebp-0xdc], eax */
            ii(0x100f_539c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_539e, 6); mov(edx, memd[ss, ebp - 220]);          /* mov edx, [ebp-0xdc] */
            ii(0x100f_53a4, 5); mov(eax, memd[ds, 0x101c_711e]);        /* mov eax, [0x101c711e] */
            ii(0x100f_53a9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_53ac, 5); call(0x100f_39b4, -0x19fd);             /* call 0x100f39b4 */
        l_0x100f_53b1:
            ii(0x100f_53b1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_53b3, 6); lea(eax, memd[ss, ebp - 208]);          /* lea eax, [ebp-0xd0] */
            ii(0x100f_53b9, 5); call(Definitions.my_string_dtor, 0x4_c76c); /* call 0x10141b2a */
        l_0x100f_53be:
            ii(0x100f_53be, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_53c0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_53c1, 1); pop(edi);                               /* pop edi */
            ii(0x100f_53c2, 1); pop(esi);                               /* pop esi */
            ii(0x100f_53c3, 1); pop(edx);                               /* pop edx */
            ii(0x100f_53c4, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_53c5, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_53c6, 1); ret();                                  /* ret */
        }
    }
}
