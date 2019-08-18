using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_e927-1fe9d120")]
        public void Method_100f_e927()
        {
            ii(0x100f_e927, 7); mov(memb_a32[ds, 0x101c_37d3], 0x1);    /* mov byte [0x101c37d3], 0x1 */
            ii(0x100f_e92e, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100f_e932, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_e937, 5); calld(0x100f_b4fd, -0x343f);            /* call 0x100fb4fd */
            ii(0x100f_e93c, 4); cmp(memb_a32[ss, ebp - 0x8], 0xa);      /* cmp byte [ebp-0x8], 0xa */
            ii(0x100f_e940, 2); if(jnzd(0x100f_e951, 0xf)) goto l_0x100f_e951; /* jnz 0x100fe951 */
            ii(0x100f_e942, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100f_e947, 5); calld(0x1007_5fdc, -0x8_8970);          /* call 0x10075fdc */
            ii(0x100f_e94c, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_e94f, 2); if(jzd(0x100f_e953, 0x2)) goto l_0x100f_e953; /* jz 0x100fe953 */
        l_0x100f_e951:
            ii(0x100f_e951, 2); jmpd(0x100f_e963, 0x10); goto l_0x100f_e963; /* jmp 0x100fe963 */
        l_0x100f_e953:
            ii(0x100f_e953, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e955, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_e95a, 5); calld(0x1013_ad71, 0x3_c412);           /* call 0x1013ad71 */
            ii(0x100f_e95f, 2); test(al, al);                           /* test al, al */
            ii(0x100f_e961, 2); if(jnzd(0x100f_e965, 0x2)) goto l_0x100f_e965; /* jnz 0x100fe965 */
        l_0x100f_e963:
            ii(0x100f_e963, 2); jmpd(0x100f_e974, 0xf); goto l_0x100f_e974; /* jmp 0x100fe974 */
        l_0x100f_e965:
            ii(0x100f_e965, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_e96a, 5); calld(0x1007_65d0, -0x8_839f);          /* call 0x100765d0 */
            ii(0x100f_e96f, 5); calld(0x100f_28a2, -0xc0d2);            /* call 0x100f28a2 */
        l_0x100f_e974:
            ii(0x100f_e974, 5); calld(0x100f_e5cd, -0x3ac);             /* call 0x100fe5cd */
            ii(0x100f_e979, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e97b, 6); if(jzd(0x100f_ea14, 0x93)) goto l_0x100f_ea14; /* jz 0x100fea14 */
            ii(0x100f_e981, 5); calld(0x1013_9c10, 0x3_b28a);           /* call 0x10139c10 */
            ii(0x100f_e986, 3); mov(memb_a32[ss, ebp - 0x1c], al);      /* mov [ebp-0x1c], al */
            ii(0x100f_e989, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_e98d, 2); if(jzd(0x100f_e995, 0x6)) goto l_0x100f_e995; /* jz 0x100fe995 */
            ii(0x100f_e98f, 4); cmp(memb_a32[ss, ebp - 0x1c], 0x5);     /* cmp byte [ebp-0x1c], 0x5 */
            ii(0x100f_e993, 2); if(jnzd(0x100f_e997, 0x2)) goto l_0x100f_e997; /* jnz 0x100fe997 */
        l_0x100f_e995:
            ii(0x100f_e995, 2); jmpd(0x100f_e9a5, 0xe); goto l_0x100f_e9a5; /* jmp 0x100fe9a5 */
        l_0x100f_e997:
            ii(0x100f_e997, 5); mov(eax, 0x3c);                         /* mov eax, 0x3c */
            ii(0x100f_e99c, 5); calld(0x1007_5fdc, -0x8_89c5);          /* call 0x10075fdc */
            ii(0x100f_e9a1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e9a3, 2); if(jnzd(0x100f_e9a7, 0x2)) goto l_0x100f_e9a7; /* jnz 0x100fe9a7 */
        l_0x100f_e9a5:
            ii(0x100f_e9a5, 2); jmpd(0x100f_e9eb, 0x44); goto l_0x100f_e9eb; /* jmp 0x100fe9eb */
        l_0x100f_e9a7:
            ii(0x100f_e9a7, 4); movsx(eax, memb_a32[ss, ebp - 0x1c]);   /* movsx eax, byte [ebp-0x1c] */
            ii(0x100f_e9ab, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_e9ae, 6); pushd(memd_a32[ds, eax + 0x101b_d42c]); /* push dword [eax+0x101bd42c] */
            ii(0x100f_e9b4, 5); mov(eax, StringDefinitions.Save10S);    /* mov eax, 0x101a2a7d */
            ii(0x100f_e9b9, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e9ba, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_e9bd, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e9be, 5); calld(Definitions.sys_sprintf, 0x6_753e); /* call 0x10165f01 */
            ii(0x100f_e9c3, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_e9c6, 6); pushd(memd_a32[ds, 0x101c_37dc]);       /* push dword [0x101c37dc] */
            ii(0x100f_e9cc, 5); mov(eax, StringDefinitions.AutoSavedTurnI); /* mov eax, 0x101a2a87 */
            ii(0x100f_e9d1, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e9d2, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x100f_e9d5, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e9d6, 5); calld(Definitions.sys_sprintf, 0x6_7526); /* call 0x10165f01 */
            ii(0x100f_e9db, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_e9de, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_e9e0, 3); lea(edx, ebp - 0x4c);                   /* lea edx, [ebp-0x4c] */
            ii(0x100f_e9e3, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_e9e6, 5); calld(0x1013_6e81, 0x3_8496);           /* call 0x10136e81 */
        l_0x100f_e9eb:
            ii(0x100f_e9eb, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_e9f0, 6); cmp(al, memb_a32[ds, 0x101c_37da]);     /* cmp al, [0x101c37da] */
            ii(0x100f_e9f6, 2); if(jnzd(0x100f_ea14, 0x1c)) goto l_0x100f_ea14; /* jnz 0x100fea14 */
            ii(0x100f_e9f8, 5); calld(0x100d_5470, -0x2_958d);          /* call 0x100d5470 */
            ii(0x100f_e9fd, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_ea00, 5); mov(ebx, 0x42c);                        /* mov ebx, 0x42c */
            ii(0x100f_ea05, 5); mov(edx, 0x42b);                        /* mov edx, 0x42b */
            ii(0x100f_ea0a, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_ea0f, 5); calld(0x1013_daea, 0x3_f0d6);           /* call 0x1013daea */
        l_0x100f_ea14:
            ii(0x100f_ea14, 7); cmp(memb_a32[ds, 0x101c_391e], 0x8);    /* cmp byte [0x101c391e], 0x8 */
            ii(0x100f_ea1b, 2); if(jnzd_func(0x100f_ea24, 0x7)) return; /* jnz 0x100fea24 */
            ii(0x100f_ea1d, 5); calld(0x1010_132c, 0x290a);             /* call 0x1010132c */
            ii(0x100f_ea22, 2); jmpd(0x100f_ea14, -0x10); goto l_0x100f_ea14; /* jmp 0x100fea14 */
        }
    }
}
