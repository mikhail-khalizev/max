using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_8c64-42052184")]
        public void /* sys */ Method_1016_8c64()
        {
            ii(0x1016_8c64, 1); push(esi);                              /* push esi */
            ii(0x1016_8c65, 1); push(edi);                              /* push edi */
            ii(0x1016_8c66, 1); push(ebp);                              /* push ebp */
            ii(0x1016_8c67, 3); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1016_8c6a, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_8c6c, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1016_8c6e, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_8c70, 3); mov(memd[ss, esp], ecx);                /* mov [esp], ecx */
            ii(0x1016_8c73, 5); call(/* sys */ 0x1016_7dac, -0xecc);    /* call 0x10167dac */
            ii(0x1016_8c78, 4); mov(memd[ss, esp + 4], eax);            /* mov [esp+0x4], eax */
            ii(0x1016_8c7c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8c7e, 6); if(jz(0x1016_8ddc, 0x158)) goto l_0x1016_8ddc; /* jz 0x10168ddc */
            ii(0x1016_8c84, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_8c86, 2); if(jl(0x1016_8cab, 0x23)) goto l_0x1016_8cab; /* jl 0x10168cab */
            ii(0x1016_8c88, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_8c8a, 2); if(jl(0x1016_8cab, 0x1f)) goto l_0x1016_8cab; /* jl 0x10168cab */
            ii(0x1016_8c8c, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_8c8e, 3); lea(ebx, memd[ds, ecx + edx]);          /* lea ebx, [ecx+edx] */
            ii(0x1016_8c91, 5); call(/* sys */ 0x1016_7e3c, -0xe5a);    /* call 0x10167e3c */
            ii(0x1016_8c96, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1016_8c98, 2); if(jg(0x1016_8cab, 0x11)) goto l_0x1016_8cab; /* jg 0x10168cab */
            ii(0x1016_8c9a, 4); mov(ebx, memd[ss, esp + 24]);           /* mov ebx, [esp+0x18] */
            ii(0x1016_8c9e, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_8ca0, 2); add(ebx, edi);                          /* add ebx, edi */
            ii(0x1016_8ca2, 5); call(/* sys */ 0x1016_7e58, -0xe4f);    /* call 0x10167e58 */
            ii(0x1016_8ca7, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1016_8ca9, 2); if(jle(0x1016_8cb2, 7)) goto l_0x1016_8cb2; /* jle 0x10168cb2 */
        l_0x1016_8cab:
            ii(0x1016_8cab, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_8cad, 5); jmp(0x1016_8ddc, 0x12a); goto l_0x1016_8ddc; /* jmp 0x10168ddc */
        l_0x1016_8cb2:
            ii(0x1016_8cb2, 5); mov(eax, 0x74);                         /* mov eax, 0x74 */
            ii(0x1016_8cb7, 5); call(Definitions.sys_malloc_internal, 0x1_9634); /* call 0x101822f0 */
            ii(0x1016_8cbc, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_8cbe, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8cc0, 6); if(jz(0x1016_8ddc, 0x116)) goto l_0x1016_8ddc; /* jz 0x10168ddc */
            ii(0x1016_8cc6, 4); mov(ah, memb[ss, esp + 44]);            /* mov ah, [esp+0x2c] */
            ii(0x1016_8cca, 3); test(ah, 1);                            /* test ah, 0x1 */
            ii(0x1016_8ccd, 2); if(jnz(0x1016_8cef, 0x20)) goto l_0x1016_8cef; /* jnz 0x10168cef */
            ii(0x1016_8ccf, 3); test(ah, 2);                            /* test ah, 0x2 */
            ii(0x1016_8cd2, 2); if(jz(0x1016_8cdd, 9)) goto l_0x1016_8cdd; /* jz 0x10168cdd */
            ii(0x1016_8cd4, 2); mov(dh, ah);                            /* mov dh, ah */
            ii(0x1016_8cd6, 3); and(dh, 0xfd);                          /* and dh, 0xfd */
            ii(0x1016_8cd9, 4); mov(memb[ss, esp + 44], dh);            /* mov [esp+0x2c], dh */
        l_0x1016_8cdd:
            ii(0x1016_8cdd, 4); mov(bl, memb[ss, esp + 44]);            /* mov bl, [esp+0x2c] */
            ii(0x1016_8ce1, 3); test(bl, 4);                            /* test bl, 0x4 */
            ii(0x1016_8ce4, 2); if(jz(0x1016_8cef, 9)) goto l_0x1016_8cef; /* jz 0x10168cef */
            ii(0x1016_8ce6, 2); mov(bh, bl);                            /* mov bh, bl */
            ii(0x1016_8ce8, 3); and(bh, 0xfb);                          /* and bh, 0xfb */
            ii(0x1016_8ceb, 4); mov(memb[ss, esp + 44], bh);            /* mov [esp+0x2c], bh */
        l_0x1016_8cef:
            ii(0x1016_8cef, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1016_8cf4, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1016_8cf6, 2); jmp(0x1016_8cf9, 1); goto l_0x1016_8cf9; /* jmp 0x10168cf9 */
        l_0x1016_8cf8:
            ii(0x1016_8cf8, 1); inc(ebx);                               /* inc ebx */
        l_0x1016_8cf9:
            ii(0x1016_8cf9, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_8cfb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_8cfd, 5); call(/* sys */ 0x1016_7f00, -0xe02);    /* call 0x10167f00 */
            ii(0x1016_8d02, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8d04, 2); if(jnz(0x1016_8cf8, -0xe)) goto l_0x1016_8cf8; /* jnz 0x10168cf8 */
            ii(0x1016_8d06, 7); mov(memd[ds, ecx + 40], 0xffff_ffff);   /* mov dword [ecx+0x28], 0xffffffff */
            ii(0x1016_8d0d, 7); mov(memd[ds, ecx + 44], 0xffff_ffff);   /* mov dword [ecx+0x2c], 0xffffffff */
            ii(0x1016_8d14, 7); mov(memd[ds, ecx + 60], 0);             /* mov dword [ecx+0x3c], 0x0 */
            ii(0x1016_8d1b, 7); mov(memd[ds, ecx + 64], 0);             /* mov dword [ecx+0x40], 0x0 */
            ii(0x1016_8d22, 7); mov(memd[ds, ecx + 68], 0);             /* mov dword [ecx+0x44], 0x0 */
            ii(0x1016_8d29, 7); mov(memd[ds, ecx + 72], 0);             /* mov dword [ecx+0x48], 0x0 */
            ii(0x1016_8d30, 7); mov(memd[ds, ecx + 76], 0);             /* mov dword [ecx+0x4c], 0x0 */
            ii(0x1016_8d37, 7); mov(memd[ds, ecx + 80], 0);             /* mov dword [ecx+0x50], 0x0 */
            ii(0x1016_8d3e, 7); mov(memd[ds, ecx + 84], 0);             /* mov dword [ecx+0x54], 0x0 */
            ii(0x1016_8d45, 7); mov(memd[ds, ecx + 88], 0);             /* mov dword [ecx+0x58], 0x0 */
            ii(0x1016_8d4c, 7); mov(memd[ds, ecx + 92], 0);             /* mov dword [ecx+0x5c], 0x0 */
            ii(0x1016_8d53, 7); mov(memd[ds, ecx + 96], 0);             /* mov dword [ecx+0x60], 0x0 */
            ii(0x1016_8d5a, 7); mov(memd[ds, ecx + 100], 0);            /* mov dword [ecx+0x64], 0x0 */
            ii(0x1016_8d61, 7); mov(memd[ds, ecx + 104], 0);            /* mov dword [ecx+0x68], 0x0 */
            ii(0x1016_8d68, 7); mov(memd[ds, ecx + 108], 0);            /* mov dword [ecx+0x6c], 0x0 */
            ii(0x1016_8d6f, 2); mov(memd[ds, ecx], ebx);                /* mov [ecx], ebx */
            ii(0x1016_8d71, 4); mov(eax, memd[ss, esp + 44]);           /* mov eax, [esp+0x2c] */
            ii(0x1016_8d75, 3); mov(memd[ds, ecx + 8], ebp);            /* mov [ecx+0x8], ebp */
            ii(0x1016_8d78, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
            ii(0x1016_8d7b, 3); mov(memd[ds, ecx + 12], edi);           /* mov [ecx+0xc], edi */
            ii(0x1016_8d7e, 2); add(ebp, edx);                          /* add ebp, edx */
            ii(0x1016_8d80, 3); mov(memd[ds, ecx + 4], eax);            /* mov [ecx+0x4], eax */
            ii(0x1016_8d83, 1); dec(ebp);                               /* dec ebp */
            ii(0x1016_8d84, 4); mov(eax, memd[ss, esp + 28]);           /* mov eax, [esp+0x1c] */
            ii(0x1016_8d88, 3); mov(memd[ds, ecx + 16], ebp);           /* mov [ecx+0x10], ebp */
            ii(0x1016_8d8b, 3); mov(memd[ds, ecx + 24], eax);           /* mov [ecx+0x18], eax */
            ii(0x1016_8d8e, 4); mov(eax, memd[ss, esp + 32]);           /* mov eax, [esp+0x20] */
            ii(0x1016_8d92, 3); mov(memd[ds, ecx + 28], eax);           /* mov [ecx+0x1c], eax */
            ii(0x1016_8d95, 4); mov(eax, memd[ss, esp + 36]);           /* mov eax, [esp+0x24] */
            ii(0x1016_8d99, 3); mov(memd[ds, ecx + 32], eax);           /* mov [ecx+0x20], eax */
            ii(0x1016_8d9c, 4); mov(eax, memd[ss, esp + 40]);           /* mov eax, [esp+0x28] */
            ii(0x1016_8da0, 3); mov(memd[ds, ecx + 36], eax);           /* mov [ecx+0x24], eax */
            ii(0x1016_8da3, 4); mov(eax, memd[ss, esp + 48]);           /* mov eax, [esp+0x30] */
            ii(0x1016_8da7, 4); mov(ebx, memd[ss, esp + 24]);           /* mov ebx, [esp+0x18] */
            ii(0x1016_8dab, 3); mov(memd[ds, ecx + 48], eax);           /* mov [ecx+0x30], eax */
            ii(0x1016_8dae, 4); mov(eax, memd[ss, esp + 52]);           /* mov eax, [esp+0x34] */
            ii(0x1016_8db2, 2); add(edi, ebx);                          /* add edi, ebx */
            ii(0x1016_8db4, 3); mov(memd[ds, ecx + 52], eax);           /* mov [ecx+0x34], eax */
            ii(0x1016_8db7, 4); mov(eax, memd[ss, esp + 56]);           /* mov eax, [esp+0x38] */
            ii(0x1016_8dbb, 1); dec(edi);                               /* dec edi */
            ii(0x1016_8dbc, 3); mov(memd[ds, ecx + 56], eax);           /* mov [ecx+0x38], eax */
            ii(0x1016_8dbf, 4); mov(eax, memd[ss, esp + 4]);            /* mov eax, [esp+0x4] */
            ii(0x1016_8dc3, 3); mov(memd[ds, ecx + 20], edi);           /* mov [ecx+0x14], edi */
            ii(0x1016_8dc6, 3); mov(eax, memd[ds, eax + 48]);           /* mov eax, [eax+0x30] */
            ii(0x1016_8dc9, 3); mov(memd[ds, ecx + 112], eax);          /* mov [ecx+0x70], eax */
            ii(0x1016_8dcc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8dce, 2); if(jz(0x1016_8dd3, 3)) goto l_0x1016_8dd3; /* jz 0x10168dd3 */
            ii(0x1016_8dd0, 3); mov(memd[ds, eax + 108], ecx);          /* mov [eax+0x6c], ecx */
        l_0x1016_8dd3:
            ii(0x1016_8dd3, 4); mov(eax, memd[ss, esp + 4]);            /* mov eax, [esp+0x4] */
            ii(0x1016_8dd7, 3); mov(memd[ds, eax + 48], ecx);           /* mov [eax+0x30], ecx */
            ii(0x1016_8dda, 2); mov(eax, ecx);                          /* mov eax, ecx */
        l_0x1016_8ddc:
            ii(0x1016_8ddc, 3); add(esp, 8);                            /* add esp, 0x8 */
            ii(0x1016_8ddf, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_8de0, 1); pop(edi);                               /* pop edi */
            ii(0x1016_8de1, 1); pop(esi);                               /* pop esi */
            ii(0x1016_8de2, 3); ret(0x24);                              /* ret 0x24 */
        }
    }
}
