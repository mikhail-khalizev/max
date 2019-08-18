using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9dd977dd-53d8-42d7-9a6f-6d9e1e2a5532")]
        public void /* sys */ Method_1017_cf49()
        {
            ii(0x1017_cf49, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_cf4a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_cf4b, 1); pushd(edx);                             /* push edx */
            ii(0x1017_cf4c, 1); pushd(esi);                             /* push esi */
            ii(0x1017_cf4d, 1); pushd(edi);                             /* push edi */
            ii(0x1017_cf4e, 3); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1017_cf51, 4); mov(esi, memd_a32[ss, esp + 0x24]);     /* mov esi, [esp+0x24] */
        l_0x1017_cf55:
            ii(0x1017_cf55, 3); movzx(edi, memb_a32[ds, esi]);          /* movzx edi, byte [esi] */
            ii(0x1017_cf58, 3); cmp(edi, 0x20);                         /* cmp edi, 0x20 */
            ii(0x1017_cf5b, 2); if(jnzd(0x1017_cf60, 0x3)) goto l_0x1017_cf60; /* jnz 0x1017cf60 */
            ii(0x1017_cf5d, 1); inc(esi);                               /* inc esi */
            ii(0x1017_cf5e, 2); jmpd(0x1017_cf55, -0xb); goto l_0x1017_cf55; /* jmp 0x1017cf55 */
        l_0x1017_cf60:
            ii(0x1017_cf60, 4); mov(eax, memd_a32[ss, esp + 0x28]);     /* mov eax, [esp+0x28] */
            ii(0x1017_cf64, 5); and(eax, 0x83);                         /* and eax, 0x83 */
            ii(0x1017_cf69, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1017_cf6d, 4); mov(al, memb_a32[ss, esp + 0x4]);       /* mov al, [esp+0x4] */
            ii(0x1017_cf71, 4); mov(ah, memb_a32[ss, esp + 0x2c]);      /* mov ah, [esp+0x2c] */
            ii(0x1017_cf75, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_cf77, 2); or(al, ah);                             /* or al, ah */
            ii(0x1017_cf79, 5); mov(edi, 0xffff_ffff);                  /* mov edi, 0xffffffff */
            ii(0x1017_cf7e, 2); mov(ah, 0x3d);                          /* mov ah, 0x3d */
            ii(0x1017_cf80, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_cf82, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1017_cf84, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1017_cf86, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1017_cf89, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_cf8b, 2); if(jld(0x1017_cf93, 0x6)) goto l_0x1017_cf93; /* jl 0x1017cf93 */
            ii(0x1017_cf8d, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1017_cf8f, 4); mov(di, memw_a32[ss, esp]);             /* mov di, [esp] */
        l_0x1017_cf93:
            ii(0x1017_cf93, 4); mov(dl, memb_a32[ss, esp + 0x28]);      /* mov dl, [esp+0x28] */
            ii(0x1017_cf97, 3); test(dl, 0x3);                          /* test dl, 0x3 */
            ii(0x1017_cf9a, 6); if(jzd(0x1017_d016, 0x76)) goto l_0x1017_d016; /* jz 0x1017d016 */
            ii(0x1017_cfa0, 3); cmp(edi, -0x1 /* 0xff */);              /* cmp edi, 0xffffffff */
            ii(0x1017_cfa3, 6); if(jzd(0x1017_d016, 0x6d)) goto l_0x1017_d016; /* jz 0x1017d016 */
            ii(0x1017_cfa9, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_cfab, 5); calld(/* sys */ 0x1019_467e, 0x1_76ce); /* call 0x1019467e */
            ii(0x1017_cfb0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_cfb2, 2); if(jnzd(0x1017_d016, 0x62)) goto l_0x1017_d016; /* jnz 0x1017d016 */
            ii(0x1017_cfb4, 5); test(memb_a32[ss, esp + 0x29], 0x4);    /* test byte [esp+0x29], 0x4 */
            ii(0x1017_cfb9, 2); if(jzd(0x1017_cfde, 0x23)) goto l_0x1017_cfde; /* jz 0x1017cfde */
            ii(0x1017_cfbb, 3); test(dl, 0x20);                         /* test dl, 0x20 */
            ii(0x1017_cfbe, 2); if(jzd(0x1017_cfde, 0x1e)) goto l_0x1017_cfde; /* jz 0x1017cfde */
            ii(0x1017_cfc0, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1017_cfc2, 2); mov(ah, 0x3e);                          /* mov ah, 0x3e */
            ii(0x1017_cfc4, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_cfc6, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1017_cfc8, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1017_cfca, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1017_cfcf, 5); calld(/* sys */ 0x1018_d3bf, 0x1_03eb); /* call 0x1018d3bf */
            ii(0x1017_cfd4, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_cfd9, 5); jmpd(0x1017_d129, 0x14b); goto l_0x1017_d129; /* jmp 0x1017d129 */
        l_0x1017_cfde:
            ii(0x1017_cfde, 5); test(memb_a32[ss, esp + 0x28], 0x40);   /* test byte [esp+0x28], 0x40 */
            ii(0x1017_cfe3, 2); if(jzd(0x1017_d016, 0x31)) goto l_0x1017_d016; /* jz 0x1017d016 */
            ii(0x1017_cfe5, 4); lea(edx, esp + 0x8);                    /* lea edx, [esp+0x8] */
            ii(0x1017_cfe9, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1017_cfeb, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_cfed, 2); mov(ah, 0x40);                          /* mov ah, 0x40 */
            ii(0x1017_cfef, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_cff1, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1017_cff3, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1017_cff5, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1017_cff8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_cffa, 2); if(jged(0x1017_d016, 0x1a)) goto l_0x1017_d016; /* jge 0x1017d016 */
            ii(0x1017_cffc, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1017_cffe, 2); mov(ah, 0x3e);                          /* mov ah, 0x3e */
            ii(0x1017_d000, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_d002, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1017_d004, 2); ror(eax, 0x1);                          /* ror eax, 1 */
        l_0x1017_d006:
            ii(0x1017_d006, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d008, 4); mov(ax, memw_a32[ss, esp]);             /* mov ax, [esp] */
            ii(0x1017_d00c, 5); calld(/* sys */ 0x1018_dbb7, 0x1_0ba6); /* call 0x1018dbb7 */
            ii(0x1017_d011, 5); jmpd(0x1017_d129, 0x113); goto l_0x1017_d129; /* jmp 0x1017d129 */
        l_0x1017_d016:
            ii(0x1017_d016, 3); cmp(edi, -0x1 /* 0xff */);              /* cmp edi, 0xffffffff */
            ii(0x1017_d019, 6); if(jnzd(0x1017_d0b8, 0x99)) goto l_0x1017_d0b8; /* jnz 0x1017d0b8 */
            ii(0x1017_d01f, 5); test(memb_a32[ss, esp + 0x28], 0x20);   /* test byte [esp+0x28], 0x20 */
            ii(0x1017_d024, 2); if(jzd(0x1017_d006, -0x20)) goto l_0x1017_d006; /* jz 0x1017d006 */
            ii(0x1017_d026, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d028, 4); mov(ax, memw_a32[ss, esp]);             /* mov ax, [esp] */
            ii(0x1017_d02c, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1017_d02f, 2); if(jnzd(0x1017_d006, -0x2b)) goto l_0x1017_d006; /* jnz 0x1017d006 */
            ii(0x1017_d031, 4); lea(eax, esp + 0x30);                   /* lea eax, [esp+0x30] */
            ii(0x1017_d035, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1017_d038, 3); mov(eax, memd_a32[ds, eax - 0x4]);      /* mov eax, [eax-0x4] */
            ii(0x1017_d03b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d03d, 2); if(jnzd(0x1017_d044, 0x5)) goto l_0x1017_d044; /* jnz 0x1017d044 */
            ii(0x1017_d03f, 5); mov(eax, 0x180);                        /* mov eax, 0x180 */
        l_0x1017_d044:
            ii(0x1017_d044, 6); mov(edx, memd_a32[ds, 0x101c_09cc]);    /* mov edx, [0x101c09cc] */
            ii(0x1017_d04a, 2); not(edx);                               /* not edx */
            ii(0x1017_d04c, 2); and(eax, edx);                          /* and eax, edx */
            ii(0x1017_d04e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_d050, 2); test(al, 0x80);                         /* test al, 0x80 */
            ii(0x1017_d052, 2); if(jnzd(0x1017_d059, 0x5)) goto l_0x1017_d059; /* jnz 0x1017d059 */
            ii(0x1017_d054, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
        l_0x1017_d059:
            ii(0x1017_d059, 6); and(ecx, 0xff);                         /* and ecx, 0xff */
            ii(0x1017_d05f, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_d061, 2); mov(ah, 0x3c);                          /* mov ah, 0x3c */
            ii(0x1017_d063, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_d065, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1017_d067, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1017_d069, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1017_d06c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d06e, 2); if(jld(0x1017_d006, -0x6a)) goto l_0x1017_d006; /* jl 0x1017d006 */
            ii(0x1017_d070, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1017_d072, 4); mov(edx, memd_a32[ss, esp + 0x2c]);     /* mov edx, [esp+0x2c] */
            ii(0x1017_d076, 4); mov(di, memw_a32[ss, esp]);             /* mov di, [esp] */
            ii(0x1017_d07a, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_d07c, 2); if(jzd(0x1017_d0b8, 0x3a)) goto l_0x1017_d0b8; /* jz 0x1017d0b8 */
            ii(0x1017_d07e, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1017_d080, 2); mov(ah, 0x3e);                          /* mov ah, 0x3e */
            ii(0x1017_d082, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_d084, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1017_d086, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1017_d088, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1017_d08b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d08d, 6); if(jld(0x1017_d006, -0x8d)) goto l_0x1017_d006; /* jl 0x1017d006 */
            ii(0x1017_d093, 4); mov(al, memb_a32[ss, esp + 0x4]);       /* mov al, [esp+0x4] */
            ii(0x1017_d097, 4); mov(ch, memb_a32[ss, esp + 0x2c]);      /* mov ch, [esp+0x2c] */
            ii(0x1017_d09b, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_d09d, 2); or(al, ch);                             /* or al, ch */
            ii(0x1017_d09f, 2); mov(ah, 0x3d);                          /* mov ah, 0x3d */
            ii(0x1017_d0a1, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_d0a3, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1017_d0a5, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1017_d0a7, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1017_d0aa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d0ac, 6); if(jld(0x1017_d006, -0xac)) goto l_0x1017_d006; /* jl 0x1017d006 */
            ii(0x1017_d0b2, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1017_d0b4, 4); mov(di, memw_a32[ss, esp]);             /* mov di, [esp] */
        l_0x1017_d0b8:
            ii(0x1017_d0b8, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_d0ba, 5); calld(/* sys */ 0x1019_46a5, 0x1_75e6); /* call 0x101946a5 */
            ii(0x1017_d0bf, 2); and(al, 0x3c);                          /* and al, 0x3c */
            ii(0x1017_d0c1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_d0c3, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_d0c5, 5); calld(/* sys */ 0x1019_467e, 0x1_75b4); /* call 0x1019467e */
            ii(0x1017_d0ca, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d0cc, 2); if(jzd(0x1017_d0d1, 0x3)) goto l_0x1017_d0d1; /* jz 0x1017d0d1 */
            ii(0x1017_d0ce, 3); or(dh, 0x20);                           /* or dh, 0x20 */
        l_0x1017_d0d1:
            ii(0x1017_d0d1, 5); and(memb_a32[ss, esp + 0x4], 0x7f);     /* and byte [esp+0x4], 0x7f */
            ii(0x1017_d0d6, 5); cmp(memd_a32[ss, esp + 0x4], 0x2);      /* cmp dword [esp+0x4], 0x2 */
            ii(0x1017_d0db, 2); if(jnzd(0x1017_d0e0, 0x3)) goto l_0x1017_d0e0; /* jnz 0x1017d0e0 */
            ii(0x1017_d0dd, 3); or(dl, 0x3);                            /* or dl, 0x3 */
        l_0x1017_d0e0:
            ii(0x1017_d0e0, 5); cmp(memd_a32[ss, esp + 0x4], 0);        /* cmp dword [esp+0x4], 0x0 */
            ii(0x1017_d0e5, 2); if(jnzd(0x1017_d0ea, 0x3)) goto l_0x1017_d0ea; /* jnz 0x1017d0ea */
            ii(0x1017_d0e7, 3); or(dl, 0x1);                            /* or dl, 0x1 */
        l_0x1017_d0ea:
            ii(0x1017_d0ea, 5); cmp(memd_a32[ss, esp + 0x4], 0x1);      /* cmp dword [esp+0x4], 0x1 */
            ii(0x1017_d0ef, 2); if(jnzd(0x1017_d0f4, 0x3)) goto l_0x1017_d0f4; /* jnz 0x1017d0f4 */
            ii(0x1017_d0f1, 3); or(dl, 0x2);                            /* or dl, 0x2 */
        l_0x1017_d0f4:
            ii(0x1017_d0f4, 5); test(memb_a32[ss, esp + 0x28], 0x10);   /* test byte [esp+0x28], 0x10 */
            ii(0x1017_d0f9, 2); if(jzd(0x1017_d0fe, 0x3)) goto l_0x1017_d0fe; /* jz 0x1017d0fe */
            ii(0x1017_d0fb, 3); or(dl, 0x80);                           /* or dl, 0x80 */
        l_0x1017_d0fe:
            ii(0x1017_d0fe, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_d100, 4); mov(bl, memb_a32[ss, esp + 0x29]);      /* mov bl, [esp+0x29] */
            ii(0x1017_d104, 2); or(al, 0x40);                           /* or al, 0x40 */
            ii(0x1017_d106, 3); test(bl, 0x3);                          /* test bl, 0x3 */
            ii(0x1017_d109, 2); if(jzd(0x1017_d112, 0x7)) goto l_0x1017_d112; /* jz 0x1017d112 */
            ii(0x1017_d10b, 3); test(bl, 0x2);                          /* test bl, 0x2 */
            ii(0x1017_d10e, 2); if(jzd(0x1017_d120, 0x10)) goto l_0x1017_d120; /* jz 0x1017d120 */
            ii(0x1017_d110, 2); jmpd(0x1017_d11e, 0xc); goto l_0x1017_d11e; /* jmp 0x1017d11e */
        l_0x1017_d112:
            ii(0x1017_d112, 10); cmp(memd_a32[ds, 0x101b_e7a9], 0x200); /* cmp dword [0x101be7a9], 0x200 */
            ii(0x1017_d11c, 2); if(jnzd(0x1017_d120, 0x2)) goto l_0x1017_d120; /* jnz 0x1017d120 */
        l_0x1017_d11e:
            ii(0x1017_d11e, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_d120:
            ii(0x1017_d120, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_d122, 5); calld(/* sys */ 0x1019_46fa, 0x1_75d3); /* call 0x101946fa */
            ii(0x1017_d127, 2); mov(eax, edi);                          /* mov eax, edi */
        l_0x1017_d129:
            ii(0x1017_d129, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1017_d12c, 1); popd(edi);                              /* pop edi */
            ii(0x1017_d12d, 1); popd(esi);                              /* pop esi */
            ii(0x1017_d12e, 1); popd(edx);                              /* pop edx */
            ii(0x1017_d12f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_d130, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_d131, 1); retd(); return;                         /* ret */
        }
    }
}
