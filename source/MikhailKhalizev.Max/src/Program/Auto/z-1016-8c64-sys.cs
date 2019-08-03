using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("32813509-fb8f-4345-87b7-b01bccd6cc2c")]
        public void /* sys */ Method_1016_8c64()
        {
            ii(0x1016_8c64, 1); pushd(esi);                             /* push esi */
            ii(0x1016_8c65, 1); pushd(edi);                             /* push edi */
            ii(0x1016_8c66, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_8c67, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_8c6a, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_8c6c, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1016_8c6e, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_8c70, 3); mov(memd_a32[ss, esp], ecx);            /* mov [esp], ecx */
            ii(0x1016_8c73, 5); calld(/* sys */ 0x1016_7dac, -0xecc);   /* call 0x10167dac */
            ii(0x1016_8c78, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1016_8c7c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8c7e, 6); if(jzd(0x1016_8ddc, 0x158)) goto l_0x1016_8ddc; /* jz 0x10168ddc */
            ii(0x1016_8c84, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_8c86, 2); if(jld(0x1016_8cab, 0x23)) goto l_0x1016_8cab; /* jl 0x10168cab */
            ii(0x1016_8c88, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_8c8a, 2); if(jld(0x1016_8cab, 0x1f)) goto l_0x1016_8cab; /* jl 0x10168cab */
            ii(0x1016_8c8c, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_8c8e, 3); lea(ebx, ecx + edx);                    /* lea ebx, [ecx+edx] */
            ii(0x1016_8c91, 5); calld(/* sys */ 0x1016_7e3c, -0xe5a);   /* call 0x10167e3c */
            ii(0x1016_8c96, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1016_8c98, 2); if(jgd(0x1016_8cab, 0x11)) goto l_0x1016_8cab; /* jg 0x10168cab */
            ii(0x1016_8c9a, 4); mov(ebx, memd_a32[ss, esp + 0x18]);     /* mov ebx, [esp+0x18] */
            ii(0x1016_8c9e, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_8ca0, 2); add(ebx, edi);                          /* add ebx, edi */
            ii(0x1016_8ca2, 5); calld(/* sys */ 0x1016_7e58, -0xe4f);   /* call 0x10167e58 */
            ii(0x1016_8ca7, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1016_8ca9, 2); if(jled(0x1016_8cb2, 0x7)) goto l_0x1016_8cb2; /* jle 0x10168cb2 */
        l_0x1016_8cab:
            ii(0x1016_8cab, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_8cad, 5); jmpd(0x1016_8ddc, 0x12a); goto l_0x1016_8ddc; /* jmp 0x10168ddc */
        l_0x1016_8cb2:
            ii(0x1016_8cb2, 5); mov(eax, 0x74);                         /* mov eax, 0x74 */
            ii(0x1016_8cb7, 5); calld(Definitions.sys_malloc_internal, 0x19634); /* call 0x101822f0 */
            ii(0x1016_8cbc, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_8cbe, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8cc0, 6); if(jzd(0x1016_8ddc, 0x116)) goto l_0x1016_8ddc; /* jz 0x10168ddc */
            ii(0x1016_8cc6, 4); mov(ah, memb_a32[ss, esp + 0x2c]);      /* mov ah, [esp+0x2c] */
            ii(0x1016_8cca, 3); test(ah, 0x1);                          /* test ah, 0x1 */
            ii(0x1016_8ccd, 2); if(jnzd(0x1016_8cef, 0x20)) goto l_0x1016_8cef; /* jnz 0x10168cef */
            ii(0x1016_8ccf, 3); test(ah, 0x2);                          /* test ah, 0x2 */
            ii(0x1016_8cd2, 2); if(jzd(0x1016_8cdd, 0x9)) goto l_0x1016_8cdd; /* jz 0x10168cdd */
            ii(0x1016_8cd4, 2); mov(dh, ah);                            /* mov dh, ah */
            ii(0x1016_8cd6, 3); and(dh, 0xfd);                          /* and dh, 0xfd */
            ii(0x1016_8cd9, 4); mov(memb_a32[ss, esp + 0x2c], dh);      /* mov [esp+0x2c], dh */
        l_0x1016_8cdd:
            ii(0x1016_8cdd, 4); mov(bl, memb_a32[ss, esp + 0x2c]);      /* mov bl, [esp+0x2c] */
            ii(0x1016_8ce1, 3); test(bl, 0x4);                          /* test bl, 0x4 */
            ii(0x1016_8ce4, 2); if(jzd(0x1016_8cef, 0x9)) goto l_0x1016_8cef; /* jz 0x10168cef */
            ii(0x1016_8ce6, 2); mov(bh, bl);                            /* mov bh, bl */
            ii(0x1016_8ce8, 3); and(bh, 0xfb);                          /* and bh, 0xfb */
            ii(0x1016_8ceb, 4); mov(memb_a32[ss, esp + 0x2c], bh);      /* mov [esp+0x2c], bh */
        l_0x1016_8cef:
            ii(0x1016_8cef, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_8cf4, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1016_8cf6, 2); jmpd(0x1016_8cf9, 0x1); goto l_0x1016_8cf9; /* jmp 0x10168cf9 */
        l_0x1016_8cf8:
            ii(0x1016_8cf8, 1); inc(ebx);                               /* inc ebx */
        l_0x1016_8cf9:
            ii(0x1016_8cf9, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_8cfb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_8cfd, 5); calld(/* sys */ 0x1016_7f00, -0xe02);   /* call 0x10167f00 */
            ii(0x1016_8d02, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8d04, 2); if(jnzd(0x1016_8cf8, -0xe)) goto l_0x1016_8cf8; /* jnz 0x10168cf8 */
            ii(0x1016_8d06, 7); mov(memd_a32[ds, ecx + 0x28], 0xffff_ffff); /* mov dword [ecx+0x28], 0xffffffff */
            ii(0x1016_8d0d, 7); mov(memd_a32[ds, ecx + 0x2c], 0xffff_ffff); /* mov dword [ecx+0x2c], 0xffffffff */
            ii(0x1016_8d14, 7); mov(memd_a32[ds, ecx + 0x3c], 0);       /* mov dword [ecx+0x3c], 0x0 */
            ii(0x1016_8d1b, 7); mov(memd_a32[ds, ecx + 0x40], 0);       /* mov dword [ecx+0x40], 0x0 */
            ii(0x1016_8d22, 7); mov(memd_a32[ds, ecx + 0x44], 0);       /* mov dword [ecx+0x44], 0x0 */
            ii(0x1016_8d29, 7); mov(memd_a32[ds, ecx + 0x48], 0);       /* mov dword [ecx+0x48], 0x0 */
            ii(0x1016_8d30, 7); mov(memd_a32[ds, ecx + 0x4c], 0);       /* mov dword [ecx+0x4c], 0x0 */
            ii(0x1016_8d37, 7); mov(memd_a32[ds, ecx + 0x50], 0);       /* mov dword [ecx+0x50], 0x0 */
            ii(0x1016_8d3e, 7); mov(memd_a32[ds, ecx + 0x54], 0);       /* mov dword [ecx+0x54], 0x0 */
            ii(0x1016_8d45, 7); mov(memd_a32[ds, ecx + 0x58], 0);       /* mov dword [ecx+0x58], 0x0 */
            ii(0x1016_8d4c, 7); mov(memd_a32[ds, ecx + 0x5c], 0);       /* mov dword [ecx+0x5c], 0x0 */
            ii(0x1016_8d53, 7); mov(memd_a32[ds, ecx + 0x60], 0);       /* mov dword [ecx+0x60], 0x0 */
            ii(0x1016_8d5a, 7); mov(memd_a32[ds, ecx + 0x64], 0);       /* mov dword [ecx+0x64], 0x0 */
            ii(0x1016_8d61, 7); mov(memd_a32[ds, ecx + 0x68], 0);       /* mov dword [ecx+0x68], 0x0 */
            ii(0x1016_8d68, 7); mov(memd_a32[ds, ecx + 0x6c], 0);       /* mov dword [ecx+0x6c], 0x0 */
            ii(0x1016_8d6f, 2); mov(memd_a32[ds, ecx], ebx);            /* mov [ecx], ebx */
            ii(0x1016_8d71, 4); mov(eax, memd_a32[ss, esp + 0x2c]);     /* mov eax, [esp+0x2c] */
            ii(0x1016_8d75, 3); mov(memd_a32[ds, ecx + 0x8], ebp);      /* mov [ecx+0x8], ebp */
            ii(0x1016_8d78, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1016_8d7b, 3); mov(memd_a32[ds, ecx + 0xc], edi);      /* mov [ecx+0xc], edi */
            ii(0x1016_8d7e, 2); add(ebp, edx);                          /* add ebp, edx */
            ii(0x1016_8d80, 3); mov(memd_a32[ds, ecx + 0x4], eax);      /* mov [ecx+0x4], eax */
            ii(0x1016_8d83, 1); dec(ebp);                               /* dec ebp */
            ii(0x1016_8d84, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_8d88, 3); mov(memd_a32[ds, ecx + 0x10], ebp);     /* mov [ecx+0x10], ebp */
            ii(0x1016_8d8b, 3); mov(memd_a32[ds, ecx + 0x18], eax);     /* mov [ecx+0x18], eax */
            ii(0x1016_8d8e, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1016_8d92, 3); mov(memd_a32[ds, ecx + 0x1c], eax);     /* mov [ecx+0x1c], eax */
            ii(0x1016_8d95, 4); mov(eax, memd_a32[ss, esp + 0x24]);     /* mov eax, [esp+0x24] */
            ii(0x1016_8d99, 3); mov(memd_a32[ds, ecx + 0x20], eax);     /* mov [ecx+0x20], eax */
            ii(0x1016_8d9c, 4); mov(eax, memd_a32[ss, esp + 0x28]);     /* mov eax, [esp+0x28] */
            ii(0x1016_8da0, 3); mov(memd_a32[ds, ecx + 0x24], eax);     /* mov [ecx+0x24], eax */
            ii(0x1016_8da3, 4); mov(eax, memd_a32[ss, esp + 0x30]);     /* mov eax, [esp+0x30] */
            ii(0x1016_8da7, 4); mov(ebx, memd_a32[ss, esp + 0x18]);     /* mov ebx, [esp+0x18] */
            ii(0x1016_8dab, 3); mov(memd_a32[ds, ecx + 0x30], eax);     /* mov [ecx+0x30], eax */
            ii(0x1016_8dae, 4); mov(eax, memd_a32[ss, esp + 0x34]);     /* mov eax, [esp+0x34] */
            ii(0x1016_8db2, 2); add(edi, ebx);                          /* add edi, ebx */
            ii(0x1016_8db4, 3); mov(memd_a32[ds, ecx + 0x34], eax);     /* mov [ecx+0x34], eax */
            ii(0x1016_8db7, 4); mov(eax, memd_a32[ss, esp + 0x38]);     /* mov eax, [esp+0x38] */
            ii(0x1016_8dbb, 1); dec(edi);                               /* dec edi */
            ii(0x1016_8dbc, 3); mov(memd_a32[ds, ecx + 0x38], eax);     /* mov [ecx+0x38], eax */
            ii(0x1016_8dbf, 4); mov(eax, memd_a32[ss, esp + 0x4]);      /* mov eax, [esp+0x4] */
            ii(0x1016_8dc3, 3); mov(memd_a32[ds, ecx + 0x14], edi);     /* mov [ecx+0x14], edi */
            ii(0x1016_8dc6, 3); mov(eax, memd_a32[ds, eax + 0x30]);     /* mov eax, [eax+0x30] */
            ii(0x1016_8dc9, 3); mov(memd_a32[ds, ecx + 0x70], eax);     /* mov [ecx+0x70], eax */
            ii(0x1016_8dcc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8dce, 2); if(jzd(0x1016_8dd3, 0x3)) goto l_0x1016_8dd3; /* jz 0x10168dd3 */
            ii(0x1016_8dd0, 3); mov(memd_a32[ds, eax + 0x6c], ecx);     /* mov [eax+0x6c], ecx */
        l_0x1016_8dd3:
            ii(0x1016_8dd3, 4); mov(eax, memd_a32[ss, esp + 0x4]);      /* mov eax, [esp+0x4] */
            ii(0x1016_8dd7, 3); mov(memd_a32[ds, eax + 0x30], ecx);     /* mov [eax+0x30], ecx */
            ii(0x1016_8dda, 2); mov(eax, ecx);                          /* mov eax, ecx */
        l_0x1016_8ddc:
            ii(0x1016_8ddc, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_8ddf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_8de0, 1); popd(edi);                              /* pop edi */
            ii(0x1016_8de1, 1); popd(esi);                              /* pop esi */
            ii(0x1016_8de2, 3); retd(0x24); return;                     /* ret 0x24 */
        }
    }
}
