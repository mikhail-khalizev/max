using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ba2afb7e-6df4-4d1a-ad01-36422cc16992")]
        public void Method_100f_1ab9()
        {
            ii(0x100f_1ab9, 5); pushd(0x12c);                           /* push 0x12c */
            ii(0x100f_1abe, 5); calld(Definitions.sys_check_available_stack_size, 0x7_428f); /* call 0x10165d52 */
            ii(0x100f_1ac3, 1); pushd(esi);                             /* push esi */
            ii(0x100f_1ac4, 1); pushd(edi);                             /* push edi */
            ii(0x100f_1ac5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_1ac6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_1ac8, 6); sub(esp, 0x10c);                        /* sub esp, 0x10c */
            ii(0x100f_1ace, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_1ad1, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100f_1ad4, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100f_1ad7, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100f_1ada, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x100f_1ae1:
            ii(0x100f_1ae1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_1ae4, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x100f_1ae7, 1); cwde();                                 /* cwde */
            ii(0x100f_1ae8, 1); pushd(eax);                             /* push eax */
            ii(0x100f_1ae9, 5); mov(eax, 0x101c_3d70);                  /* mov eax, 0x101c3d70 */
            ii(0x100f_1aee, 1); pushd(eax);                             /* push eax */
            ii(0x100f_1aef, 5); mov(eax, StringDefinitions.Smax44iPcx); /* mov eax, 0x101a22f8 */
            ii(0x100f_1af4, 1); pushd(eax);                             /* push eax */
            ii(0x100f_1af5, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x100f_1af8, 1); pushd(eax);                             /* push eax */
            ii(0x100f_1af9, 5); calld(Definitions.sys_sprintf, 0x7_4403); /* call 0x10165f01 */
            ii(0x100f_1afe, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100f_1b01, 5); mov(edx, StringDefinitions.Rb13);       /* mov edx, 0x101a2307 */
            ii(0x100f_1b06, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x100f_1b09, 5); calld(Definitions.sys_fopen, 0x8_086c); /* call 0x1017237a */
            ii(0x100f_1b0e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_1b11, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100f_1b15, 2); if(jzd(0x100f_1b1f, 0x8)) goto l_0x100f_1b1f; /* jz 0x100f1b1f */
            ii(0x100f_1b17, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_1b1a, 5); calld(Definitions.sys_fclose, 0x8_054a); /* call 0x10172069 */
        l_0x100f_1b1f:
            ii(0x100f_1b1f, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100f_1b23, 2); if(jnzd(0x100f_1ae1, -0x44)) goto l_0x100f_1ae1; /* jnz 0x100f1ae1 */
            ii(0x100f_1b25, 7); mov(memd_a32[ss, ebp - 0x14], 0x300);   /* mov dword [ebp-0x14], 0x300 */
        l_0x100f_1b2c:
            ii(0x100f_1b2c, 3); dec(memd_a32[ss, ebp - 0x14]);          /* dec dword [ebp-0x14] */
            ii(0x100f_1b2f, 5); cmp(memw_a32[ss, ebp - 0x14], -0x1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x100f_1b34, 2); if(jzd(0x100f_1b42, 0xc)) goto l_0x100f_1b42; /* jz 0x100f1b42 */
            ii(0x100f_1b36, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_1b3a, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100f_1b3d, 3); shl(memb_a32[ds, eax], 0x2);            /* shl byte [eax], 0x2 */
            ii(0x100f_1b40, 2); jmpd(0x100f_1b2c, -0x16); goto l_0x100f_1b2c; /* jmp 0x100f1b2c */
        l_0x100f_1b42:
            ii(0x100f_1b42, 5); mov(edx, StringDefinitions.Wb2);        /* mov edx, 0x101a230a */
            ii(0x100f_1b47, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x100f_1b4a, 5); calld(Definitions.sys_fopen, 0x8_082b); /* call 0x1017237a */
            ii(0x100f_1b4f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_1b52, 5); mov(ebx, 0x80);                         /* mov ebx, 0x80 */
            ii(0x100f_1b57, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_1b59, 6); lea(eax, ebp - 0x100);                  /* lea eax, [ebp-0x100] */
            ii(0x100f_1b5f, 5); calld(Definitions.sys_memset, 0x7_427c); /* call 0x10165de0 */
            ii(0x100f_1b64, 7); mov(memb_a32[ss, ebp - 0x100], 0xa);    /* mov byte [ebp-0x100], 0xa */
            ii(0x100f_1b6b, 7); mov(memb_a32[ss, ebp - 0xff], 0x5);     /* mov byte [ebp-0xff], 0x5 */
            ii(0x100f_1b72, 7); mov(memb_a32[ss, ebp - 0xfe], 0x1);     /* mov byte [ebp-0xfe], 0x1 */
            ii(0x100f_1b79, 7); mov(memb_a32[ss, ebp - 0xfd], 0x8);     /* mov byte [ebp-0xfd], 0x8 */
            ii(0x100f_1b80, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_1b83, 1); dec(eax);                               /* dec eax */
            ii(0x100f_1b84, 7); mov(memw_a32[ss, ebp - 0xf8], ax);      /* mov [ebp-0xf8], ax */
            ii(0x100f_1b8b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_1b8e, 1); dec(eax);                               /* dec eax */
            ii(0x100f_1b8f, 7); mov(memw_a32[ss, ebp - 0xf6], ax);      /* mov [ebp-0xf6], ax */
            ii(0x100f_1b96, 7); mov(memb_a32[ss, ebp - 0xbf], 0x1);     /* mov byte [ebp-0xbf], 0x1 */
            ii(0x100f_1b9d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_1ba0, 7); mov(memw_a32[ss, ebp - 0xbe], ax);      /* mov [ebp-0xbe], ax */
            ii(0x100f_1ba7, 9); mov(memw_a32[ss, ebp - 0xbc], 0x1);     /* mov word [ebp-0xbc], 0x1 */
            ii(0x100f_1bb0, 5); mov(ebx, 0x30);                         /* mov ebx, 0x30 */
            ii(0x100f_1bb5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_1bb8, 6); lea(eax, ebp - 0xf0);                   /* lea eax, [ebp-0xf0] */
            ii(0x100f_1bbe, 5); calld(Definitions.sys_memcpy, 0x7_4288); /* call 0x10165e4b */
            ii(0x100f_1bc3, 3); mov(ecx, memd_a32[ss, ebp - 0x1c]);     /* mov ecx, [ebp-0x1c] */
            ii(0x100f_1bc6, 5); mov(ebx, 0x80);                         /* mov ebx, 0x80 */
            ii(0x100f_1bcb, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_1bd0, 6); lea(eax, ebp - 0x100);                  /* lea eax, [ebp-0x100] */
            ii(0x100f_1bd6, 5); calld(/* sys */ 0x1017_2831, 0x8_0c56); /* call 0x10172831 */
        l_0x100f_1bdb:
            ii(0x100f_1bdb, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x100f_1bde, 4); cmp(memd_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp dword [ebp-0xc], 0xffffffff */
            ii(0x100f_1be2, 6); if(jzd(0x100f_1ccb, 0xe3)) goto l_0x100f_1ccb; /* jz 0x100f1ccb */
            ii(0x100f_1be8, 10); mov(memd_a32[ss, ebp - 0x104], 0);     /* mov dword [ebp-0x104], 0x0 */
        l_0x100f_1bf2:
            ii(0x100f_1bf2, 10); mov(memd_a32[ss, ebp - 0x108], 0x1);   /* mov dword [ebp-0x108], 0x1 */
        l_0x100f_1bfc:
            ii(0x100f_1bfc, 7); movsx(edx, memw_a32[ss, ebp - 0x104]);  /* movsx edx, word [ebp-0x104] */
            ii(0x100f_1c03, 7); movsx(eax, memw_a32[ss, ebp - 0x108]);  /* movsx eax, word [ebp-0x108] */
            ii(0x100f_1c0a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_1c0c, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100f_1c0f, 7); movsx(edx, memw_a32[ss, ebp - 0x104]);  /* movsx edx, word [ebp-0x104] */
            ii(0x100f_1c16, 7); movsx(ebx, memw_a32[ss, ebp - 0x108]);  /* movsx ebx, word [ebp-0x108] */
            ii(0x100f_1c1d, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100f_1c1f, 3); add(edx, memd_a32[ss, ebp - 0x8]);      /* add edx, [ebp-0x8] */
            ii(0x100f_1c22, 3); mov(al, memb_a32[ds, eax - 0x1]);       /* mov al, [eax-0x1] */
            ii(0x100f_1c25, 2); cmp(al, memb_a32[ds, edx]);             /* cmp al, [edx] */
            ii(0x100f_1c27, 2); if(jnzd(0x100f_1c3e, 0x15)) goto l_0x100f_1c3e; /* jnz 0x100f1c3e */
            ii(0x100f_1c29, 7); movsx(edx, memw_a32[ss, ebp - 0x104]);  /* movsx edx, word [ebp-0x104] */
            ii(0x100f_1c30, 7); movsx(eax, memw_a32[ss, ebp - 0x108]);  /* movsx eax, word [ebp-0x108] */
            ii(0x100f_1c37, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_1c39, 3); cmp(eax, memd_a32[ss, ebp - 0x10]);     /* cmp eax, [ebp-0x10] */
            ii(0x100f_1c3c, 2); if(jld(0x100f_1c40, 0x2)) goto l_0x100f_1c40; /* jl 0x100f1c40 */
        l_0x100f_1c3e:
            ii(0x100f_1c3e, 2); jmpd(0x100f_1c4c, 0xc); goto l_0x100f_1c4c; /* jmp 0x100f1c4c */
        l_0x100f_1c40:
            ii(0x100f_1c40, 7); movsx(eax, memw_a32[ss, ebp - 0x108]);  /* movsx eax, word [ebp-0x108] */
            ii(0x100f_1c47, 3); cmp(eax, 0x3f);                         /* cmp eax, 0x3f */
            ii(0x100f_1c4a, 2); if(jld(0x100f_1c4e, 0x2)) goto l_0x100f_1c4e; /* jl 0x100f1c4e */
        l_0x100f_1c4c:
            ii(0x100f_1c4c, 2); jmpd(0x100f_1c5c, 0xe); goto l_0x100f_1c5c; /* jmp 0x100f1c5c */
        l_0x100f_1c4e:
            ii(0x100f_1c4e, 6); mov(eax, memd_a32[ss, ebp - 0x108]);    /* mov eax, [ebp-0x108] */
            ii(0x100f_1c54, 6); inc(memd_a32[ss, ebp - 0x108]);         /* inc dword [ebp-0x108] */
            ii(0x100f_1c5a, 2); jmpd(0x100f_1bfc, -0x60); goto l_0x100f_1bfc; /* jmp 0x100f1bfc */
        l_0x100f_1c5c:
            ii(0x100f_1c5c, 7); movsx(eax, memw_a32[ss, ebp - 0x108]);  /* movsx eax, word [ebp-0x108] */
            ii(0x100f_1c63, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_1c66, 2); if(jgd(0x100f_1c7a, 0x12)) goto l_0x100f_1c7a; /* jg 0x100f1c7a */
            ii(0x100f_1c68, 7); movsx(eax, memw_a32[ss, ebp - 0x104]);  /* movsx eax, word [ebp-0x104] */
            ii(0x100f_1c6f, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100f_1c72, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100f_1c74, 2); and(al, 0xc0);                          /* and al, 0xc0 */
            ii(0x100f_1c76, 2); cmp(al, -0x40 /* 0xc0 */);              /* cmp al, 0xc0 */
            ii(0x100f_1c78, 2); if(jnzd(0x100f_1c8b, 0x11)) goto l_0x100f_1c8b; /* jnz 0x100f1c8b */
        l_0x100f_1c7a:
            ii(0x100f_1c7a, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100f_1c7d, 6); mov(eax, memd_a32[ss, ebp - 0x108]);    /* mov eax, [ebp-0x108] */
            ii(0x100f_1c83, 2); or(al, 0xc0);                           /* or al, 0xc0 */
            ii(0x100f_1c85, 1); cwde();                                 /* cwde */
            ii(0x100f_1c86, 5); calld(/* sys */ 0x1017_29f1, 0x8_0d66); /* call 0x101729f1 */
        l_0x100f_1c8b:
            ii(0x100f_1c8b, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100f_1c8e, 7); movsx(eax, memw_a32[ss, ebp - 0x104]);  /* movsx eax, word [ebp-0x104] */
            ii(0x100f_1c95, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100f_1c98, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100f_1c9a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_1c9f, 5); calld(/* sys */ 0x1017_29f1, 0x8_0d4d); /* call 0x101729f1 */
            ii(0x100f_1ca4, 6); mov(eax, memd_a32[ss, ebp - 0x108]);    /* mov eax, [ebp-0x108] */
            ii(0x100f_1caa, 6); add(memd_a32[ss, ebp - 0x104], eax);    /* add [ebp-0x104], eax */
            ii(0x100f_1cb0, 7); movsx(eax, memw_a32[ss, ebp - 0x104]);  /* movsx eax, word [ebp-0x104] */
            ii(0x100f_1cb7, 3); cmp(eax, memd_a32[ss, ebp - 0x10]);     /* cmp eax, [ebp-0x10] */
            ii(0x100f_1cba, 6); if(jld(0x100f_1bf2, -0xce)) goto l_0x100f_1bf2; /* jl 0x100f1bf2 */
            ii(0x100f_1cc0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_1cc3, 3); add(memd_a32[ss, ebp - 0x8], eax);      /* add [ebp-0x8], eax */
            ii(0x100f_1cc6, 5); jmpd(0x100f_1bdb, -0xf0); goto l_0x100f_1bdb; /* jmp 0x100f1bdb */
        l_0x100f_1ccb:
            ii(0x100f_1ccb, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100f_1cce, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x100f_1cd3, 5); calld(/* sys */ 0x1017_29f1, 0x8_0d19); /* call 0x101729f1 */
            ii(0x100f_1cd8, 3); mov(ecx, memd_a32[ss, ebp - 0x1c]);     /* mov ecx, [ebp-0x1c] */
            ii(0x100f_1cdb, 5); mov(ebx, 0x300);                        /* mov ebx, 0x300 */
            ii(0x100f_1ce0, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_1ce5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_1ce8, 5); calld(/* sys */ 0x1017_2831, 0x8_0b44); /* call 0x10172831 */
            ii(0x100f_1ced, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_1cf0, 5); calld(Definitions.sys_fclose, 0x8_0374); /* call 0x10172069 */
            ii(0x100f_1cf5, 7); mov(memd_a32[ss, ebp - 0x14], 0x300);   /* mov dword [ebp-0x14], 0x300 */
        l_0x100f_1cfc:
            ii(0x100f_1cfc, 3); dec(memd_a32[ss, ebp - 0x14]);          /* dec dword [ebp-0x14] */
            ii(0x100f_1cff, 5); cmp(memw_a32[ss, ebp - 0x14], -0x1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x100f_1d04, 2); if(jzd(0x100f_1d12, 0xc)) goto l_0x100f_1d12; /* jz 0x100f1d12 */
            ii(0x100f_1d06, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_1d0a, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100f_1d0d, 3); shr(memb_a32[ds, eax], 0x2);            /* shr byte [eax], 0x2 */
            ii(0x100f_1d10, 2); jmpd(0x100f_1cfc, -0x16); goto l_0x100f_1cfc; /* jmp 0x100f1cfc */
        l_0x100f_1d12:
            ii(0x100f_1d12, 10); mov(memd_a32[ss, ebp - 0x10c], 0);     /* mov dword [ebp-0x10c], 0x0 */
            ii(0x100f_1d1c, 6); mov(eax, memd_a32[ss, ebp - 0x10c]);    /* mov eax, [ebp-0x10c] */
            ii(0x100f_1d22, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_1d24, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_1d25, 1); popd(edi);                              /* pop edi */
            ii(0x100f_1d26, 1); popd(esi);                              /* pop esi */
            ii(0x100f_1d27, 1); retd(); return;                         /* ret */
        }
    }
}
