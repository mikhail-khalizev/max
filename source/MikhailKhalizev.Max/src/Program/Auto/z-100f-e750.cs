using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f457a587-cfd6-4d79-8dce-6b5b9c448375")]
        public void Method_100f_e750()
        {
            ii(0x100f_e750, 5); pushd(0x6c);                            /* push 0x6c */
            ii(0x100f_e755, 5); calld(Definitions.sys_check_available_stack_size, 0x675f8); /* call 0x10165d52 */
            ii(0x100f_e75a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_e75b, 1); pushd(esi);                             /* push esi */
            ii(0x100f_e75c, 1); pushd(edi);                             /* push edi */
            ii(0x100f_e75d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_e75e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_e760, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x100f_e766, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_e769, 3); mov(memb_a32[ss, ebp - 0x8], dl);       /* mov [ebp-0x8], dl */
            ii(0x100f_e76c, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100f_e76f, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100f_e772, 5); mov(memb_a32[ds, 0x101c_37c8], al);     /* mov [0x101c37c8], al */
            ii(0x100f_e777, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e779, 5); calld(0x100f_fa70, 0x12f2);             /* call 0x100ffa70 */
            ii(0x100f_e77e, 4); cmp(memb_a32[ss, ebp - 0x8], 0xa);      /* cmp byte [ebp-0x8], 0xa */
            ii(0x100f_e782, 2); if(jnzd(0x100f_e7aa, 0x26)) goto l_0x100f_e7aa; /* jnz 0x100fe7aa */
            ii(0x100f_e784, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x100f_e789, 5); calld(0x1007_5fdc, -0x887b2);           /* call 0x10075fdc */
            ii(0x100f_e78e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_e791, 5); mov(al, memb_a32[ds, 0x101c_391f]);     /* mov al, [0x101c391f] */
            ii(0x100f_e796, 5); mov(memb_a32[ds, 0x101c_391e], al);     /* mov [0x101c391e], al */
            ii(0x100f_e79b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e79d, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_e7a2, 1); cwde();                                 /* cwde */
            ii(0x100f_e7a3, 5); calld(0x100f_3800, -0xafa8);            /* call 0x100f3800 */
            ii(0x100f_e7a8, 2); jmpd(0x100f_e7be, 0x14); goto l_0x100f_e7be; /* jmp 0x100fe7be */
        l_0x100f_e7aa:
            ii(0x100f_e7aa, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x100f_e7af, 5); calld(0x1007_5fdc, -0x887d8);           /* call 0x10075fdc */
            ii(0x100f_e7b4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_e7b7, 7); mov(memb_a32[ds, 0x101c_391e], 0xb);    /* mov byte [0x101c391e], 0xb */
        l_0x100f_e7be:
            ii(0x100f_e7be, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100f_e7c2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e7c4, 2); if(jnzd(0x100f_e7e3, 0x1d)) goto l_0x100f_e7e3; /* jnz 0x100fe7e3 */
            ii(0x100f_e7c6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e7c8, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_e7cd, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_e7d3, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_e7d9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_e7de, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100f_e7e1, 2); if(jzd(0x100f_e7e5, 0x2)) goto l_0x100f_e7e5; /* jz 0x100fe7e5 */
        l_0x100f_e7e3:
            ii(0x100f_e7e3, 2); jmpd(0x100f_e7ec, 0x7); goto l_0x100f_e7ec; /* jmp 0x100fe7ec */
        l_0x100f_e7e5:
            ii(0x100f_e7e5, 7); mov(memd_a32[ss, ebp - 0x10], 0x2d);    /* mov dword [ebp-0x10], 0x2d */
        l_0x100f_e7ec:
            ii(0x100f_e7ec, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e7f0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_e7f6, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_e7fc, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100f_e7ff, 5); jmpd(0x100f_e90c, 0x108); goto l_0x100f_e90c; /* jmp 0x100fe90c */
        //  ii(0x100f_e804, 242); Недостижимый код.
l_0x100f_e8f6:
            ii(0x100f_e8f6, 2); jmpd(0x100f_e927, 0x2f); goto l_0x100f_e927; /* jmp 0x100fe927 */
        //  ii(0x100f_e8f8, 20); Недостижимый код.
l_0x100f_e90c:
            ii(0x100f_e90c, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100f_e90f, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x100f_e912, 4); cmp(memb_a32[ss, ebp - 0x18], 0x4);     /* cmp byte [ebp-0x18], 0x4 */
            ii(0x100f_e916, 2); if(jad(0x100f_e8f6, -0x22)) goto l_0x100f_e8f6; /* ja 0x100fe8f6 */
            ii(0x100f_e918, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e91a, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x100f_e91d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_e920, 7); jmpd_abs(memd_a32[cs, eax + 0x100f_e8f8]); return; /* jmp dword [cs:eax+0x100fe8f8] */
        l_0x100f_e927:
            ii(0x100f_e927, 7); mov(memb_a32[ds, 0x101c_37d3], 0x1);    /* mov byte [0x101c37d3], 0x1 */
            ii(0x100f_e92e, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100f_e932, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_e937, 5); calld(0x100f_b4fd, -0x343f);            /* call 0x100fb4fd */
            ii(0x100f_e93c, 4); cmp(memb_a32[ss, ebp - 0x8], 0xa);      /* cmp byte [ebp-0x8], 0xa */
            ii(0x100f_e940, 2); if(jnzd(0x100f_e951, 0xf)) goto l_0x100f_e951; /* jnz 0x100fe951 */
            ii(0x100f_e942, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100f_e947, 5); calld(0x1007_5fdc, -0x88970);           /* call 0x10075fdc */
            ii(0x100f_e94c, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_e94f, 2); if(jzd(0x100f_e953, 0x2)) goto l_0x100f_e953; /* jz 0x100fe953 */
        l_0x100f_e951:
            ii(0x100f_e951, 2); jmpd(0x100f_e963, 0x10); goto l_0x100f_e963; /* jmp 0x100fe963 */
        l_0x100f_e953:
            ii(0x100f_e953, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e955, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_e95a, 5); calld(0x1013_ad71, 0x3c412);            /* call 0x1013ad71 */
            ii(0x100f_e95f, 2); test(al, al);                           /* test al, al */
            ii(0x100f_e961, 2); if(jnzd(0x100f_e965, 0x2)) goto l_0x100f_e965; /* jnz 0x100fe965 */
        l_0x100f_e963:
            ii(0x100f_e963, 2); jmpd(0x100f_e974, 0xf); goto l_0x100f_e974; /* jmp 0x100fe974 */
        l_0x100f_e965:
            ii(0x100f_e965, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_e96a, 5); calld(0x1007_65d0, -0x8839f);           /* call 0x100765d0 */
            ii(0x100f_e96f, 5); calld(0x100f_28a2, -0xc0d2);            /* call 0x100f28a2 */
        l_0x100f_e974:
            ii(0x100f_e974, 5); calld(0x100f_e5cd, -0x3ac);             /* call 0x100fe5cd */
            ii(0x100f_e979, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e97b, 6); if(jzd(0x100f_ea14, 0x93)) goto l_0x100f_ea14; /* jz 0x100fea14 */
            ii(0x100f_e981, 5); calld(0x1013_9c10, 0x3b28a);            /* call 0x10139c10 */
            ii(0x100f_e986, 3); mov(memb_a32[ss, ebp - 0x1c], al);      /* mov [ebp-0x1c], al */
            ii(0x100f_e989, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_e98d, 2); if(jzd(0x100f_e995, 0x6)) goto l_0x100f_e995; /* jz 0x100fe995 */
            ii(0x100f_e98f, 4); cmp(memb_a32[ss, ebp - 0x1c], 0x5);     /* cmp byte [ebp-0x1c], 0x5 */
            ii(0x100f_e993, 2); if(jnzd(0x100f_e997, 0x2)) goto l_0x100f_e997; /* jnz 0x100fe997 */
        l_0x100f_e995:
            ii(0x100f_e995, 2); jmpd(0x100f_e9a5, 0xe); goto l_0x100f_e9a5; /* jmp 0x100fe9a5 */
        l_0x100f_e997:
            ii(0x100f_e997, 5); mov(eax, 0x3c);                         /* mov eax, 0x3c */
            ii(0x100f_e99c, 5); calld(0x1007_5fdc, -0x889c5);           /* call 0x10075fdc */
            ii(0x100f_e9a1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e9a3, 2); if(jnzd(0x100f_e9a7, 0x2)) goto l_0x100f_e9a7; /* jnz 0x100fe9a7 */
        l_0x100f_e9a5:
            ii(0x100f_e9a5, 2); jmpd(0x100f_e9eb, 0x44); goto l_0x100f_e9eb; /* jmp 0x100fe9eb */
        l_0x100f_e9a7:
            ii(0x100f_e9a7, 4); movsx(eax, memb_a32[ss, ebp - 0x1c]);   /* movsx eax, byte [ebp-0x1c] */
            ii(0x100f_e9ab, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_e9ae, 6); pushd(memd_a32[ds, eax + 0x101b_d42c]); /* push dword [eax+0x101bd42c] */
            ii(0x100f_e9b4, 5); mov(eax, 0x101a_2a7d);                  /* mov eax, 0x101a2a7d */ /* "save10.%s" */
            ii(0x100f_e9b9, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e9ba, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_e9bd, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e9be, 5); calld(Definitions.sys_sprintf, 0x6753e); /* call 0x10165f01 */
            ii(0x100f_e9c3, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_e9c6, 6); pushd(memd_a32[ds, 0x101c_37dc]);       /* push dword [0x101c37dc] */
            ii(0x100f_e9cc, 5); mov(eax, 0x101a_2a87);                  /* mov eax, 0x101a2a87 */ /* "Auto-Saved turn %i" */
            ii(0x100f_e9d1, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e9d2, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x100f_e9d5, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e9d6, 5); calld(Definitions.sys_sprintf, 0x67526); /* call 0x10165f01 */
            ii(0x100f_e9db, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_e9de, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_e9e0, 3); lea(edx, ebp - 0x4c);                   /* lea edx, [ebp-0x4c] */
            ii(0x100f_e9e3, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_e9e6, 5); calld(0x1013_6e81, 0x38496);            /* call 0x10136e81 */
        l_0x100f_e9eb:
            ii(0x100f_e9eb, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_e9f0, 6); cmp(al, memb_a32[ds, 0x101c_37da]);     /* cmp al, [0x101c37da] */
            ii(0x100f_e9f6, 2); if(jnzd(0x100f_ea14, 0x1c)) goto l_0x100f_ea14; /* jnz 0x100fea14 */
            ii(0x100f_e9f8, 5); calld(0x100d_5470, -0x2958d);           /* call 0x100d5470 */
            ii(0x100f_e9fd, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_ea00, 5); mov(ebx, 0x42c);                        /* mov ebx, 0x42c */
            ii(0x100f_ea05, 5); mov(edx, 0x42b);                        /* mov edx, 0x42b */
            ii(0x100f_ea0a, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_ea0f, 5); calld(0x1013_daea, 0x3f0d6);            /* call 0x1013daea */
        l_0x100f_ea14:
            ii(0x100f_ea14, 7); cmp(memb_a32[ds, 0x101c_391e], 0x8);    /* cmp byte [0x101c391e], 0x8 */
            ii(0x100f_ea1b, 2); if(jnzd(0x100f_ea24, 0x7)) goto l_0x100f_ea24; /* jnz 0x100fea24 */
            ii(0x100f_ea1d, 5); calld(0x1010_132c, 0x290a);             /* call 0x1010132c */
            ii(0x100f_ea22, 2); jmpd(0x100f_ea14, -0x10); goto l_0x100f_ea14; /* jmp 0x100fea14 */
        l_0x100f_ea24:
            ii(0x100f_ea24, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_ea26, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_ea27, 1); popd(edi);                              /* pop edi */
            ii(0x100f_ea28, 1); popd(esi);                              /* pop esi */
            ii(0x100f_ea29, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_ea2a, 1); retd(); return;                         /* ret */
        }
    }
}
