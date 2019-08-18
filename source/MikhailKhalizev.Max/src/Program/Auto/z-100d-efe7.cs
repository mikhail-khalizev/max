using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_efe7-1a39a528")]
        public void Method_100d_efe7()
        {
            ii(0x100d_efe7, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100d_efec, 5); calld(Definitions.sys_check_available_stack_size, 0x8_6d61); /* call 0x10165d52 */
            ii(0x100d_eff1, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_eff2, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_eff3, 1); pushd(esi);                             /* push esi */
            ii(0x100d_eff4, 1); pushd(edi);                             /* push edi */
            ii(0x100d_eff5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_eff6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_eff8, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100d_effe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_f001, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_f004, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100d_f008, 2); if(jled(0x100d_f013, 0x9)) goto l_0x100d_f013; /* jle 0x100df013 */
            ii(0x100d_f00a, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x100d_f011, 2); if(jld(0x100d_f015, 0x2)) goto l_0x100d_f015; /* jl 0x100df015 */
        l_0x100d_f013:
            ii(0x100d_f013, 2); jmpd(0x100d_f01f, 0xa); goto l_0x100d_f01f; /* jmp 0x100df01f */
        l_0x100d_f015:
            ii(0x100d_f015, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f018, 7); mov(memb_a32[ds, eax + 0x39e], 0);      /* mov byte [eax+0x39e], 0x0 */
        l_0x100d_f01f:
            ii(0x100d_f01f, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3f7);    /* cmp dword [ebp-0x4], 0x3f7 */
            ii(0x100d_f026, 2); if(jld(0x100d_f031, 0x9)) goto l_0x100d_f031; /* jl 0x100df031 */
            ii(0x100d_f028, 7); cmp(memd_a32[ss, ebp - 0x4], 0x401);    /* cmp dword [ebp-0x4], 0x401 */
            ii(0x100d_f02f, 2); if(jld(0x100d_f033, 0x2)) goto l_0x100d_f033; /* jl 0x100df033 */
        l_0x100d_f031:
            ii(0x100d_f031, 2); jmpd(0x100d_f05a, 0x27); goto l_0x100d_f05a; /* jmp 0x100df05a */
        l_0x100d_f033:
            ii(0x100d_f033, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f036, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_f039, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100d_f03c, 6); mov(eax, memd_a32[ds, eax - 0xc67]);    /* mov eax, [eax-0xc67] */
            ii(0x100d_f042, 5); calld(0x100e_0b74, 0x1b2d);             /* call 0x100e0b74 */
            ii(0x100d_f047, 2); cmp(al, 0x9);                           /* cmp al, 0x9 */
            ii(0x100d_f049, 2); if(jnzd(0x100d_f058, 0xd)) goto l_0x100d_f058; /* jnz 0x100df058 */
            ii(0x100d_f04b, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_f050, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f053, 5); calld(0x100d_edef, -0x269);             /* call 0x100dedef */
        l_0x100d_f058:
            ii(0x100d_f058, 2); jmpd(0x100d_f093, 0x39); goto l_0x100d_f093; /* jmp 0x100df093 */
        l_0x100d_f05a:
            ii(0x100d_f05a, 7); cmp(memd_a32[ss, ebp - 0x4], 0x401);    /* cmp dword [ebp-0x4], 0x401 */
            ii(0x100d_f061, 2); if(jld(0x100d_f06c, 0x9)) goto l_0x100d_f06c; /* jl 0x100df06c */
            ii(0x100d_f063, 7); cmp(memd_a32[ss, ebp - 0x4], 0x40b);    /* cmp dword [ebp-0x4], 0x40b */
            ii(0x100d_f06a, 2); if(jld(0x100d_f06e, 0x2)) goto l_0x100d_f06e; /* jl 0x100df06e */
        l_0x100d_f06c:
            ii(0x100d_f06c, 2); jmpd(0x100d_f093, 0x25); goto l_0x100d_f093; /* jmp 0x100df093 */
        l_0x100d_f06e:
            ii(0x100d_f06e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f071, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_f074, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100d_f077, 6); mov(eax, memd_a32[ds, eax - 0xc8f]);    /* mov eax, [eax-0xc8f] */
            ii(0x100d_f07d, 5); calld(0x100e_0b74, 0x1af2);             /* call 0x100e0b74 */
            ii(0x100d_f082, 2); cmp(al, 0x9);                           /* cmp al, 0x9 */
            ii(0x100d_f084, 2); if(jnzd(0x100d_f093, 0xd)) goto l_0x100d_f093; /* jnz 0x100df093 */
            ii(0x100d_f086, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x100d_f08b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f08e, 5); calld(0x100d_edef, -0x2a4);             /* call 0x100dedef */
        l_0x100d_f093:
            ii(0x100d_f093, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f096, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_f099, 5); jmpd(0x100d_f1d4, 0x136); goto l_0x100d_f1d4; /* jmp 0x100df1d4 */
        l_0x100d_f09e:
            ii(0x100d_f09e, 5); calld(0x1011_6ba6, 0x3_7b03);           /* call 0x10116ba6 */
            ii(0x100d_f0a3, 5); jmpd(0x100d_f24e, 0x1a6); goto l_0x100d_f24e; /* jmp 0x100df24e */
        l_0x100d_f0a8:
            ii(0x100d_f0a8, 5); calld(0x100d_4e6c, -0xa241);            /* call 0x100d4e6c */
            ii(0x100d_f0ad, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_f0af, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_f0b1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f0b3, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x100d_f0b8, 5); calld(0x1010_5b00, 0x2_6a43);           /* call 0x10105b00 */
            ii(0x100d_f0bd, 5); jmpd(0x100d_f24e, 0x18c); goto l_0x100d_f24e; /* jmp 0x100df24e */
        l_0x100d_f0c2:
            ii(0x100d_f0c2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f0c5, 6); mov(eax, memd_a32[ds, eax + 0x3d3]);    /* mov eax, [eax+0x3d3] */
            ii(0x100d_f0cb, 5); calld(0x100c_fbbe, -0xf512);            /* call 0x100cfbbe */
            ii(0x100d_f0d0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f0d3, 7); mov(memb_a32[ds, eax + 0x39d], 0x1);    /* mov byte [eax+0x39d], 0x1 */
            ii(0x100d_f0da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f0dd, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_f0e0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_f0e3, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_f0e6, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_f0e9, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_f0ec, 5); jmpd(0x100d_f24e, 0x15d); goto l_0x100d_f24e; /* jmp 0x100df24e */
        l_0x100d_f0f1:
            ii(0x100d_f0f1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f0f4, 6); mov(eax, memd_a32[ds, eax + 0x3d3]);    /* mov eax, [eax+0x3d3] */
            ii(0x100d_f0fa, 5); calld(0x100c_fbbe, -0xf541);            /* call 0x100cfbbe */
            ii(0x100d_f0ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f102, 7); mov(memb_a32[ds, eax + 0x39d], 0);      /* mov byte [eax+0x39d], 0x0 */
            ii(0x100d_f109, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f10c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_f10f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_f112, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_f115, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_f118, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_f11b, 5); jmpd(0x100d_f24e, 0x12e); goto l_0x100d_f24e; /* jmp 0x100df24e */
        l_0x100d_f120:
            ii(0x100d_f120, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f123, 5); calld(0x100d_e493, -0xc95);             /* call 0x100de493 */
            ii(0x100d_f128, 5); jmpd(0x100d_f24e, 0x121); goto l_0x100d_f24e; /* jmp 0x100df24e */
        l_0x100d_f12d:
            ii(0x100d_f12d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f130, 5); calld(0x100d_e575, -0xbc0);             /* call 0x100de575 */
            ii(0x100d_f135, 5); jmpd(0x100d_f24e, 0x114); goto l_0x100d_f24e; /* jmp 0x100df24e */
        l_0x100d_f13a:
            ii(0x100d_f13a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f13d, 6); mov(eax, memd_a32[ds, eax + 0x3bf]);    /* mov eax, [eax+0x3bf] */
            ii(0x100d_f143, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_f146, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_f149, 3); mov(ebx, memd_a32[ds, eax + 0x40]);     /* mov ebx, [eax+0x40] */
            ii(0x100d_f14c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_f14f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_f152, 3); calld_abs(memd_a32[ds, ebx + 0xc]);     /* call dword [ebx+0xc] */
            ii(0x100d_f155, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f157, 2); if(jnzd(0x100d_f178, 0x1f)) goto l_0x100d_f178; /* jnz 0x100df178 */
            ii(0x100d_f159, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f15c, 6); mov(eax, memd_a32[ds, eax + 0x3bb]);    /* mov eax, [eax+0x3bb] */
            ii(0x100d_f162, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_f165, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_f168, 3); mov(ebx, memd_a32[ds, eax + 0x40]);     /* mov ebx, [eax+0x40] */
            ii(0x100d_f16b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_f16e, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_f171, 3); calld_abs(memd_a32[ds, ebx + 0xc]);     /* call dword [ebx+0xc] */
            ii(0x100d_f174, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f176, 2); if(jzd(0x100d_f17a, 0x2)) goto l_0x100d_f17a; /* jz 0x100df17a */
        l_0x100d_f178:
            ii(0x100d_f178, 2); jmpd(0x100d_f199, 0x1f); goto l_0x100d_f199; /* jmp 0x100df199 */
        l_0x100d_f17a:
            ii(0x100d_f17a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f17d, 6); mov(eax, memd_a32[ds, eax + 0x3df]);    /* mov eax, [eax+0x3df] */
            ii(0x100d_f183, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100d_f186, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_f189, 3); mov(ebx, memd_a32[ds, eax + 0x27]);     /* mov ebx, [eax+0x27] */
            ii(0x100d_f18c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_f18f, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_f192, 3); calld_abs(memd_a32[ds, ebx + 0xc]);     /* call dword [ebx+0xc] */
            ii(0x100d_f195, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f197, 2); if(jzd(0x100d_f19b, 0x2)) goto l_0x100d_f19b; /* jz 0x100df19b */
        l_0x100d_f199:
            ii(0x100d_f199, 2); jmpd(0x100d_f1cf, 0x34); goto l_0x100d_f1cf; /* jmp 0x100df1cf */
        l_0x100d_f19b:
            ii(0x100d_f19b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_f19e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f1a1, 5); calld(0x100d_ad31, -0x4475);            /* call 0x100dad31 */
            ii(0x100d_f1a6, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f1a8, 2); if(jnzd(0x100d_f1b3, 0x9)) goto l_0x100d_f1b3; /* jnz 0x100df1b3 */
            ii(0x100d_f1aa, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100d_f1ae, 5); jmpd(0x100d_f252, 0x9f); goto l_0x100d_f252; /* jmp 0x100df252 */
        l_0x100d_f1b3:
            ii(0x100d_f1b3, 7); cmp(memd_a32[ss, ebp - 0x4], 0x401);    /* cmp dword [ebp-0x4], 0x401 */
            ii(0x100d_f1ba, 2); if(jld(0x100d_f1c5, 0x9)) goto l_0x100d_f1c5; /* jl 0x100df1c5 */
            ii(0x100d_f1bc, 7); cmp(memd_a32[ss, ebp - 0x4], 0x40b);    /* cmp dword [ebp-0x4], 0x40b */
            ii(0x100d_f1c3, 2); if(jld(0x100d_f1c7, 0x2)) goto l_0x100d_f1c7; /* jl 0x100df1c7 */
        l_0x100d_f1c5:
            ii(0x100d_f1c5, 2); jmpd(0x100d_f1cf, 0x8); goto l_0x100d_f1cf; /* jmp 0x100df1cf */
        l_0x100d_f1c7:
            ii(0x100d_f1c7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f1ca, 5); calld(0x100d_eb16, -0x6b9);             /* call 0x100deb16 */
        l_0x100d_f1cf:
            ii(0x100d_f1cf, 5); jmpd(0x100d_f24e, 0x7a); goto l_0x100d_f24e; /* jmp 0x100df24e */
        l_0x100d_f1d4:
            ii(0x100d_f1d4, 7); cmp(memd_a32[ss, ebp - 0x10], 0x44c);   /* cmp dword [ebp-0x10], 0x44c */
            ii(0x100d_f1db, 2); if(jbd(0x100d_f217, 0x3a)) goto l_0x100d_f217; /* jb 0x100df217 */
            ii(0x100d_f1dd, 7); cmp(memd_a32[ss, ebp - 0x10], 0x44c);   /* cmp dword [ebp-0x10], 0x44c */
            ii(0x100d_f1e4, 6); if(jbed(0x100d_f0c2, -0x128)) goto l_0x100d_f0c2; /* jbe 0x100df0c2 */
            ii(0x100d_f1ea, 7); cmp(memd_a32[ss, ebp - 0x10], 0x44e);   /* cmp dword [ebp-0x10], 0x44e */
            ii(0x100d_f1f1, 2); if(jbd(0x100d_f212, 0x1f)) goto l_0x100d_f212; /* jb 0x100df212 */
            ii(0x100d_f1f3, 7); cmp(memd_a32[ss, ebp - 0x10], 0x44e);   /* cmp dword [ebp-0x10], 0x44e */
            ii(0x100d_f1fa, 6); if(jbed(0x100d_f120, -0xe0)) goto l_0x100d_f120; /* jbe 0x100df120 */
            ii(0x100d_f200, 7); cmp(memd_a32[ss, ebp - 0x10], 0x44f);   /* cmp dword [ebp-0x10], 0x44f */
            ii(0x100d_f207, 6); if(jzd(0x100d_f12d, -0xe0)) goto l_0x100d_f12d; /* jz 0x100df12d */
            ii(0x100d_f20d, 5); jmpd(0x100d_f13a, -0xd8); goto l_0x100d_f13a; /* jmp 0x100df13a */
        l_0x100d_f212:
            ii(0x100d_f212, 5); jmpd(0x100d_f0f1, -0x126); goto l_0x100d_f0f1; /* jmp 0x100df0f1 */
        l_0x100d_f217:
            ii(0x100d_f217, 7); cmp(memd_a32[ss, ebp - 0x10], 0x119);   /* cmp dword [ebp-0x10], 0x119 */
            ii(0x100d_f21e, 2); if(jbd(0x100d_f23f, 0x1f)) goto l_0x100d_f23f; /* jb 0x100df23f */
            ii(0x100d_f220, 7); cmp(memd_a32[ss, ebp - 0x10], 0x119);   /* cmp dword [ebp-0x10], 0x119 */
            ii(0x100d_f227, 6); if(jbed(0x100d_f09e, -0x18f)) goto l_0x100d_f09e; /* jbe 0x100df09e */
            ii(0x100d_f22d, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3e9);   /* cmp dword [ebp-0x10], 0x3e9 */
            ii(0x100d_f234, 6); if(jzd(0x100d_f0a8, -0x192)) goto l_0x100d_f0a8; /* jz 0x100df0a8 */
            ii(0x100d_f23a, 5); jmpd(0x100d_f13a, -0x105); goto l_0x100d_f13a; /* jmp 0x100df13a */
        l_0x100d_f23f:
            ii(0x100d_f23f, 4); cmp(memd_a32[ss, ebp - 0x10], 0x3f);    /* cmp dword [ebp-0x10], 0x3f */
            ii(0x100d_f243, 6); if(jzd(0x100d_f0a8, -0x1a1)) goto l_0x100d_f0a8; /* jz 0x100df0a8 */
            ii(0x100d_f249, 5); jmpd(0x100d_f13a, -0x114); goto l_0x100d_f13a; /* jmp 0x100df13a */
        l_0x100d_f24e:
            ii(0x100d_f24e, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x100d_f252:
            ii(0x100d_f252, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100d_f255, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_f257, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_f258, 1); popd(edi);                              /* pop edi */
            ii(0x100d_f259, 1); popd(esi);                              /* pop esi */
            ii(0x100d_f25a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_f25b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_f25c, 1); retd(); return;                         /* ret */
        }
    }
}
