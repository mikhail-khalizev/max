using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_bfb8-6ff8bbd5")]
        public void /* sys */ Method_1016_bfb8()
        {
            ii(0x1016_bfb8, 1); push(ecx);                              /* push ecx */
            ii(0x1016_bfb9, 1); push(esi);                              /* push esi */
            ii(0x1016_bfba, 1); push(ebp);                              /* push ebp */
            ii(0x1016_bfbb, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_bfbe, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_bfc0, 7); cmp(memd[ds, 0x101c_fbe8], 0);          /* cmp dword [0x101cfbe8], 0x0 */
            ii(0x1016_bfc7, 6); if(jz(0x1016_c17c, 0x1af)) goto l_0x1016_c17c; /* jz 0x1016c17c */
            ii(0x1016_bfcd, 7); cmp(memd[ds, 0x101c_fb90], 0);          /* cmp dword [0x101cfb90], 0x0 */
            ii(0x1016_bfd4, 6); if(jnz(0x1016_c17c, 0x1a2)) goto l_0x1016_c17c; /* jnz 0x1016c17c */
            ii(0x1016_bfda, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_bfdc, 2); if(jnz(0x1016_bfea, 0xc)) goto l_0x1016_bfea; /* jnz 0x1016bfea */
            ii(0x1016_bfde, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_bfe0, 2); if(jnz(0x1016_bfea, 8)) goto l_0x1016_bfea; /* jnz 0x1016bfea */
            ii(0x1016_bfe2, 6); cmp(ebx, memd[ds, 0x101b_de7c]);        /* cmp ebx, [0x101bde7c] */
            ii(0x1016_bfe8, 2); if(jz(0x1016_c05c, 0x72)) goto l_0x1016_c05c; /* jz 0x1016c05c */
        l_0x1016_bfea:
            ii(0x1016_bfea, 7); cmp(memd[ds, 0x101b_e85c], 0);          /* cmp dword [0x101be85c], 0x0 */
            ii(0x1016_bff1, 3); setz(al);                               /* setz al */
            ii(0x1016_bff4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_bff9, 2); if(jz(0x1016_c05c, 0x61)) goto l_0x1016_c05c; /* jz 0x1016c05c */
            ii(0x1016_bffb, 10); cmp(memd[ds, 0x101b_e858], 0xfff);     /* cmp dword [0x101be858], 0xfff */
            ii(0x1016_c005, 3); setz(al);                               /* setz al */
            ii(0x1016_c008, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_c00d, 2); if(jz(0x1016_c014, 5)) goto l_0x1016_c014; /* jz 0x1016c014 */
            ii(0x1016_c00f, 5); call(/* sys */ 0x1018_66ac, 0x1_a698);  /* call 0x101866ac */
        l_0x1016_c014:
            ii(0x1016_c014, 6); mov(esi, memd[ds, 0x101b_e858]);        /* mov esi, [0x101be858] */
            ii(0x1016_c01a, 7); lea(eax, memd[ds, esi * 4]);            /* lea eax, [esi*4] */
            ii(0x1016_c021, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1016_c023, 6); mov(esi, memd[ds, 0x101b_e854]);        /* mov esi, [0x101be854] */
            ii(0x1016_c029, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1016_c02c, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1016_c02e, 6); mov(memd[ds, eax], 3);                  /* mov dword [eax], 0x3 */
            ii(0x1016_c034, 3); mov(memd[ds, eax + 0xc], ecx);          /* mov [eax+0xc], ecx */
            ii(0x1016_c037, 6); mov(ebp, memd[ds, 0x101b_e858]);        /* mov ebp, [0x101be858] */
            ii(0x1016_c03d, 3); mov(memd[ds, eax + 0x10], edx);         /* mov [eax+0x10], edx */
            ii(0x1016_c040, 6); mov(esi, memd[ds, 0x101b_e860]);        /* mov esi, [0x101be860] */
            ii(0x1016_c046, 3); mov(memd[ds, eax + 0x14], ebx);         /* mov [eax+0x14], ebx */
            ii(0x1016_c049, 1); inc(ebp);                               /* inc ebp */
            ii(0x1016_c04a, 3); mov(memd[ds, eax + 4], esi);            /* mov [eax+0x4], esi */
            ii(0x1016_c04d, 6); mov(esi, memd[ds, 0x101b_e864]);        /* mov esi, [0x101be864] */
            ii(0x1016_c053, 6); mov(memd[ds, 0x101b_e858], ebp);        /* mov [0x101be858], ebp */
            ii(0x1016_c059, 3); mov(memd[ds, eax + 8], esi);            /* mov [eax+0x8], esi */
        l_0x1016_c05c:
            ii(0x1016_c05c, 5); mov(eax, memd[ds, 0x101c_fbdc]);        /* mov eax, [0x101cfbdc] */
            ii(0x1016_c061, 5); mov(memd[ds, 0x101c_fc10], eax);        /* mov [0x101cfc10], eax */
            ii(0x1016_c066, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_c068, 5); mov(memd[ds, 0x101c_fbdc], eax);        /* mov [0x101cfbdc], eax */
            ii(0x1016_c06d, 6); mov(ah, memb[ds, 0x101c_fc10]);         /* mov ah, [0x101cfc10] */
            ii(0x1016_c073, 6); mov(memd[ds, 0x101b_de7c], ebx);        /* mov [0x101bde7c], ebx */
            ii(0x1016_c079, 3); test(ah, 5);                            /* test ah, 0x5 */
            ii(0x1016_c07c, 2); if(jz(0x1016_c0b4, 0x36)) goto l_0x1016_c0b4; /* jz 0x1016c0b4 */
            ii(0x1016_c07e, 3); test(bl, 1);                            /* test bl, 0x1 */
            ii(0x1016_c081, 2); if(jz(0x1016_c0a8, 0x25)) goto l_0x1016_c0a8; /* jz 0x1016c0a8 */
            ii(0x1016_c083, 5); mov(ebp, 4);                            /* mov ebp, 0x4 */
            ii(0x1016_c088, 5); mov(eax, memd[ds, 0x101c_fc0c]);        /* mov eax, [0x101cfc0c] */
            ii(0x1016_c08d, 6); mov(memd[ds, 0x101c_fbdc], ebp);        /* mov [0x101cfbdc], ebp */
            ii(0x1016_c093, 5); call(/* sys */ 0x1016_b898, -0x800);    /* call 0x1016b898 */
            ii(0x1016_c098, 5); cmp(eax, 0xfa);                         /* cmp eax, 0xfa */
            ii(0x1016_c09d, 2); if(jbe(0x1016_c0cd, 0x2e)) goto l_0x1016_c0cd; /* jbe 0x1016c0cd */
            ii(0x1016_c09f, 7); or(memb[ds, 0x101c_fbdc], 1);           /* or byte [0x101cfbdc], 0x1 */
            ii(0x1016_c0a6, 2); jmp(0x1016_c0c3, 0x1b); goto l_0x1016_c0c3; /* jmp 0x1016c0c3 */
        l_0x1016_c0a8:
            ii(0x1016_c0a8, 10); mov(memd[ds, 0x101c_fbdc], 0x10);      /* mov dword [0x101cfbdc], 0x10 */
            ii(0x1016_c0b2, 2); jmp(0x1016_c0cd, 0x19); goto l_0x1016_c0cd; /* jmp 0x1016c0cd */
        l_0x1016_c0b4:
            ii(0x1016_c0b4, 3); test(bl, 1);                            /* test bl, 0x1 */
            ii(0x1016_c0b7, 2); if(jz(0x1016_c0cd, 0x14)) goto l_0x1016_c0cd; /* jz 0x1016c0cd */
            ii(0x1016_c0b9, 10); mov(memd[ds, 0x101c_fbdc], 1);         /* mov dword [0x101cfbdc], 0x1 */
        l_0x1016_c0c3:
            ii(0x1016_c0c3, 5); call(/* sys */ 0x1016_b7b8, -0x910);    /* call 0x1016b7b8 */
            ii(0x1016_c0c8, 5); mov(memd[ds, 0x101c_fc0c], eax);        /* mov [0x101cfc0c], eax */
        l_0x1016_c0cd:
            ii(0x1016_c0cd, 7); test(memb[ds, 0x101c_fc10], 0xa);       /* test byte [0x101cfc10], 0xa */
            ii(0x1016_c0d4, 2); if(jz(0x1016_c0fe, 0x28)) goto l_0x1016_c0fe; /* jz 0x1016c0fe */
            ii(0x1016_c0d6, 3); test(bl, 2);                            /* test bl, 0x2 */
            ii(0x1016_c0d9, 2); if(jz(0x1016_c0f5, 0x1a)) goto l_0x1016_c0f5; /* jz 0x1016c0f5 */
            ii(0x1016_c0db, 7); or(memb[ds, 0x101c_fbdc], 8);           /* or byte [0x101cfbdc], 0x8 */
            ii(0x1016_c0e2, 5); mov(eax, memd[ds, 0x101c_fc08]);        /* mov eax, [0x101cfc08] */
            ii(0x1016_c0e7, 5); call(/* sys */ 0x1016_b898, -0x854);    /* call 0x1016b898 */
            ii(0x1016_c0ec, 5); cmp(eax, 0xfa);                         /* cmp eax, 0xfa */
            ii(0x1016_c0f1, 2); if(jbe(0x1016_c114, 0x21)) goto l_0x1016_c114; /* jbe 0x1016c114 */
            ii(0x1016_c0f3, 2); jmp(0x1016_c103, 0xe); goto l_0x1016_c103; /* jmp 0x1016c103 */
        l_0x1016_c0f5:
            ii(0x1016_c0f5, 7); or(memb[ds, 0x101c_fbdc], 0x20);        /* or byte [0x101cfbdc], 0x20 */
            ii(0x1016_c0fc, 2); jmp(0x1016_c114, 0x16); goto l_0x1016_c114; /* jmp 0x1016c114 */
        l_0x1016_c0fe:
            ii(0x1016_c0fe, 3); test(bl, 2);                            /* test bl, 0x2 */
            ii(0x1016_c101, 2); if(jz(0x1016_c114, 0x11)) goto l_0x1016_c114; /* jz 0x1016c114 */
        l_0x1016_c103:
            ii(0x1016_c103, 7); or(memb[ds, 0x101c_fbdc], 2);           /* or byte [0x101cfbdc], 0x2 */
            ii(0x1016_c10a, 5); call(/* sys */ 0x1016_b7b8, -0x957);    /* call 0x1016b7b8 */
            ii(0x1016_c10f, 5); mov(memd[ds, 0x101c_fc08], eax);        /* mov [0x101cfc08], eax */
        l_0x1016_c114:
            ii(0x1016_c114, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_c116, 2); if(jnz(0x1016_c11c, 4)) goto l_0x1016_c11c; /* jnz 0x1016c11c */
            ii(0x1016_c118, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_c11a, 2); if(jz(0x1016_c17c, 0x60)) goto l_0x1016_c17c; /* jz 0x1016c17c */
        l_0x1016_c11c:
            ii(0x1016_c11c, 5); mov(eax, memd[ds, 0x101c_fbd4]);        /* mov eax, [0x101cfbd4] */
            ii(0x1016_c121, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1016_c124, 5); mov(eax, memd[ds, 0x101c_fbd0]);        /* mov eax, [0x101cfbd0] */
            ii(0x1016_c129, 6); mov(ebx, memd[ds, 0x101c_fbf0]);        /* mov ebx, [0x101cfbf0] */
            ii(0x1016_c12f, 4); mov(memd[ss, esp + 4], eax);            /* mov [esp+0x4], eax */
            ii(0x1016_c133, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_c136, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_c138, 1); dec(eax);                               /* dec eax */
            ii(0x1016_c139, 6); mov(esi, memd[ds, 0x101c_fb94]);        /* mov esi, [0x101cfb94] */
            ii(0x1016_c13f, 4); mov(memd[ss, esp + 8], eax);            /* mov [esp+0x8], eax */
            ii(0x1016_c143, 4); mov(eax, memd[ss, esp + 4]);            /* mov eax, [esp+0x4] */
            ii(0x1016_c147, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1016_c149, 1); dec(eax);                               /* dec eax */
            ii(0x1016_c14a, 3); mov(ebx, memd[ss, esp]);                /* mov ebx, [esp] */
            ii(0x1016_c14d, 4); mov(memd[ss, esp + 0xc], eax);          /* mov [esp+0xc], eax */
            ii(0x1016_c151, 3); movsx(eax, cx);                         /* movsx eax, cx */
            ii(0x1016_c154, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1016_c156, 3); movsx(eax, dx);                         /* movsx eax, dx */
            ii(0x1016_c159, 4); mov(edx, memd[ss, esp + 4]);            /* mov edx, [esp+0x4] */
            ii(0x1016_c15d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_c15f, 6); mov(memd[ds, 0x101c_fbd4], ebx);        /* mov [0x101cfbd4], ebx */
            ii(0x1016_c165, 6); mov(memd[ds, 0x101c_fbd0], edx);        /* mov [0x101cfbd0], edx */
            ii(0x1016_c16b, 5); call(/* sys */ 0x1016_c2e0, 0x170);     /* call 0x1016c2e0 */
            ii(0x1016_c170, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_c172, 5); call(/* sys */ 0x1016_7ac0, -0x46b7);   /* call 0x10167ac0 */
            ii(0x1016_c177, 5); call(/* sys */ 0x1016_bcc4, -0x4b8);    /* call 0x1016bcc4 */
        l_0x1016_c17c:
            ii(0x1016_c17c, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_c17f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_c180, 1); pop(esi);                               /* pop esi */
            ii(0x1016_c181, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_c182, 1); ret();                                  /* ret */
        }
    }
}
