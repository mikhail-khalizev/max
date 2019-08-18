using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("406fa468-9cea-4fd0-b8b3-c9cda6221f25")]
        public void Method_100e_4971()
        {
            ii(0x100e_4971, 5); pushd(0x8c);                            /* push 0x8c */
            ii(0x100e_4976, 5); calld(Definitions.sys_check_available_stack_size, 0x8_13d7); /* call 0x10165d52 */
            ii(0x100e_497b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_497c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_497d, 1); pushd(edx);                             /* push edx */
            ii(0x100e_497e, 1); pushd(esi);                             /* push esi */
            ii(0x100e_497f, 1); pushd(edi);                             /* push edi */
            ii(0x100e_4980, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_4981, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4983, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x100e_4989, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_498c, 5); calld(0x100e_4373, -0x61e);             /* call 0x100e4373 */
            ii(0x100e_4991, 5); mov(memd_a32[ds, 0x101b_7f26], eax);    /* mov [0x101b7f26], eax */
            ii(0x100e_4996, 5); mov(edx, 0x101b_7f18);                  /* mov edx, 0x101b7f18 */
            ii(0x100e_499b, 5); mov(eax, 0x400);                        /* mov eax, 0x400 */
            ii(0x100e_49a0, 5); calld(0x100e_43e1, -0x5c4);             /* call 0x100e43e1 */
            ii(0x100e_49a5, 5); mov(memd_a32[ds, 0x101b_7f14], eax);    /* mov [0x101b7f14], eax */
            ii(0x100e_49aa, 7); cmp(memd_a32[ds, 0x101b_7f14], 0);      /* cmp dword [0x101b7f14], 0x0 */
            ii(0x100e_49b1, 2); if(jnzd(0x100e_49d4, 0x21)) goto l_0x100e_49d4; /* jnz 0x100e49d4 */
            ii(0x100e_49b3, 9); mov(memw_a32[ds, 0x101b_7f18], 0);      /* mov word [0x101b7f18], 0x0 */
            ii(0x100e_49bc, 5); mov(eax, StringDefinitions.ErrorAllocating1kOfDosMemory); /* mov eax, 0x101a1c7f */
            ii(0x100e_49c1, 1); pushd(eax);                             /* push eax */
            ii(0x100e_49c2, 5); calld(Definitions.sys_printf, 0x8_7c75); /* call 0x1016c63c */
            ii(0x100e_49c7, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x100e_49ca, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_49cf, 5); calld(Definitions.sys_exit, 0x8_7c8b);  /* call 0x1016c65f */
        l_0x100e_49d4:
            ii(0x100e_49d4, 5); mov(eax, 0x100e_4935);                  /* mov eax, 0x100e4935 */
            ii(0x100e_49d9, 5); calld(/* sys */ 0x1016_c6c8, 0x8_7cea); /* call 0x1016c6c8 */
            ii(0x100e_49de, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_49e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_49e5, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100e_49e8, 5); calld(Definitions.sys_memset, 0x8_13f3); /* call 0x10165de0 */
            ii(0x100e_49ed, 7); mov(memd_a32[ss, ebp - 0x30], 0x400);   /* mov dword [ebp-0x30], 0x400 */
            ii(0x100e_49f4, 3); lea(ebx, ebp - 0x30);                   /* lea ebx, [ebp-0x30] */
            ii(0x100e_49f7, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100e_49fa, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_49ff, 5); calld(/* sys */ 0x1016_c606, 0x8_7c02); /* call 0x1016c606 */
            ii(0x100e_4a04, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100e_4a08, 2); if(jnzd(0x100e_4a6c, 0x62)) goto l_0x100e_4a6c; /* jnz 0x100e4a6c */
            ii(0x100e_4a0a, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100e_4a0e, 2); if(jzd(0x100e_4a30, 0x20)) goto l_0x100e_4a30; /* jz 0x100e4a30 */
            ii(0x100e_4a10, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_4a12, 3); mov(al, memb_a32[ss, ebp - 0x28]);      /* mov al, [ebp-0x28] */
            ii(0x100e_4a15, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4a16, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_4a18, 3); mov(al, memb_a32[ss, ebp - 0x30]);      /* mov al, [ebp-0x30] */
            ii(0x100e_4a1b, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4a1c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_4a1e, 3); mov(al, memb_a32[ss, ebp - 0x2f]);      /* mov al, [ebp-0x2f] */
            ii(0x100e_4a21, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4a22, 5); mov(eax, StringDefinitions.VDDCpuDVmm); /* mov eax, 0x101a1ca2 */
            ii(0x100e_4a27, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4a28, 5); calld(Definitions.sys_printf, 0x8_7c0f); /* call 0x1016c63c */
            ii(0x100e_4a2d, 3); add(esp, 0x10);                         /* add esp, 0x10 */
        l_0x100e_4a30:
            ii(0x100e_4a30, 6); test(memw_a32[ss, ebp - 0x2c], 0x4);    /* test word [ebp-0x2c], 0x4 */
            ii(0x100e_4a36, 2); if(jzd(0x100e_4a58, 0x20)) goto l_0x100e_4a58; /* jz 0x100e4a58 */
            ii(0x100e_4a38, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100e_4a3c, 2); if(jzd(0x100e_4a4c, 0xe)) goto l_0x100e_4a4c; /* jz 0x100e4a4c */
            ii(0x100e_4a3e, 5); mov(eax, StringDefinitions._1);         /* mov eax, 0x101a1cb7 */
            ii(0x100e_4a43, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4a44, 5); calld(Definitions.sys_printf, 0x8_7bf3); /* call 0x1016c63c */
            ii(0x100e_4a49, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x100e_4a4c:
            ii(0x100e_4a4c, 10); mov(memd_a32[ds, 0x101b_7f1a], 0x1);   /* mov dword [0x101b7f1a], 0x1 */
            ii(0x100e_4a56, 2); jmpd(0x100e_4a6c, 0x14); goto l_0x100e_4a6c; /* jmp 0x100e4a6c */
        l_0x100e_4a58:
            ii(0x100e_4a58, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100e_4a5c, 2); if(jzd(0x100e_4a6c, 0xe)) goto l_0x100e_4a6c; /* jz 0x100e4a6c */
            ii(0x100e_4a5e, 5); mov(eax, StringDefinitions._0);         /* mov eax, 0x101a1cb9 */
            ii(0x100e_4a63, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4a64, 5); calld(Definitions.sys_printf, 0x8_7bd3); /* call 0x1016c63c */
            ii(0x100e_4a69, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x100e_4a6c:
            ii(0x100e_4a6c, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_4a71, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_4a73, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100e_4a76, 5); calld(Definitions.sys_memset, 0x8_1365); /* call 0x10165de0 */
            ii(0x100e_4a7b, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x100e_4a80, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_4a82, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_4a85, 5); calld(Definitions.sys_memset, 0x8_1356); /* call 0x10165de0 */
            ii(0x100e_4a8a, 7); mov(memd_a32[ss, ebp - 0x30], 0x500);   /* mov dword [ebp-0x30], 0x500 */
            ii(0x100e_4a91, 2); mov(ebx, ss);                           /* mov ebx, ss */
            ii(0x100e_4a93, 3); lea(edx, ebp - 0x60);                   /* lea edx, [ebp-0x60] */
            ii(0x100e_4a96, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_4a98, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100e_4a9a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_4a9c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_4a9e, 4); mov(memw_a32[ss, ebp - 0x14], dx);      /* mov [ebp-0x14], dx */
            ii(0x100e_4aa2, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100e_4aa5, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_4aa8, 3); lea(ecx, ebp - 0x14);                   /* lea ecx, [ebp-0x14] */
            ii(0x100e_4aab, 3); lea(ebx, ebp - 0x30);                   /* lea ebx, [ebp-0x30] */
            ii(0x100e_4aae, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100e_4ab1, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_4ab6, 5); calld(/* sys */ 0x1016_c623, 0x8_7b68); /* call 0x1016c623 */
            ii(0x100e_4abb, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100e_4abf, 2); if(jnzd(0x100e_4b23, 0x62)) goto l_0x100e_4b23; /* jnz 0x100e4b23 */
            ii(0x100e_4ac1, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100e_4ac5, 2); if(jzd(0x100e_4adc, 0x15)) goto l_0x100e_4adc; /* jz 0x100e4adc */
            ii(0x100e_4ac7, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100e_4aca, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_4acd, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4ace, 5); mov(eax, StringDefinitions.PDk);        /* mov eax, 0x101a1cbb */
            ii(0x100e_4ad3, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4ad4, 5); calld(Definitions.sys_printf, 0x8_7b63); /* call 0x1016c63c */
            ii(0x100e_4ad9, 3); add(esp, 0x8);                          /* add esp, 0x8 */
        l_0x100e_4adc:
            ii(0x100e_4adc, 7); cmp(memd_a32[ds, 0x101b_7f1a], 0);      /* cmp dword [0x101b7f1a], 0x0 */
            ii(0x100e_4ae3, 2); if(jzd(0x100e_4b0b, 0x26)) goto l_0x100e_4b0b; /* jz 0x100e4b0b */
            ii(0x100e_4ae5, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100e_4ae9, 2); if(jzd(0x100e_4b0b, 0x20)) goto l_0x100e_4b0b; /* jz 0x100e4b0b */
            ii(0x100e_4aeb, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100e_4aee, 3); mov(edx, memd_a32[ss, ebp - 0x60]);     /* mov edx, [ebp-0x60] */
            ii(0x100e_4af1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_4af4, 3); shl(edx, 0xa);                          /* shl edx, 0xa */
            ii(0x100e_4af7, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100e_4af9, 3); sar(eax, 0xa);                          /* sar eax, 0xa */
            ii(0x100e_4afc, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4afd, 5); mov(eax, StringDefinitions.ADk);        /* mov eax, 0x101a1cc3 */
            ii(0x100e_4b02, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4b03, 5); calld(Definitions.sys_printf, 0x8_7b34); /* call 0x1016c63c */
            ii(0x100e_4b08, 3); add(esp, 0x8);                          /* add esp, 0x8 */
        l_0x100e_4b0b:
            ii(0x100e_4b0b, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100e_4b0e, 3); shl(eax, 0xc);                          /* shl eax, 0xc */
            ii(0x100e_4b11, 5); mov(memd_a32[ds, 0x101b_7f22], eax);    /* mov [0x101b7f22], eax */
            ii(0x100e_4b16, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100e_4b19, 3); shl(eax, 0xc);                          /* shl eax, 0xc */
            ii(0x100e_4b1c, 5); mov(memd_a32[ds, 0x101b_7f1e], eax);    /* mov [0x101b7f1e], eax */
            ii(0x100e_4b21, 2); jmpd(0x100e_4b4b, 0x28); goto l_0x100e_4b4b; /* jmp 0x100e4b4b */
        l_0x100e_4b23:
            ii(0x100e_4b23, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100e_4b27, 2); if(jzd(0x100e_4b37, 0xe)) goto l_0x100e_4b37; /* jz 0x100e4b37 */
            ii(0x100e_4b29, 5); mov(eax, StringDefinitions.MeminfoFailed); /* mov eax, 0x101a1ccb */
            ii(0x100e_4b2e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4b2f, 5); calld(Definitions.sys_printf, 0x8_7b08); /* call 0x1016c63c */
            ii(0x100e_4b34, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x100e_4b37:
            ii(0x100e_4b37, 10); mov(memd_a32[ds, 0x101b_7f22], 0x100_0000); /* mov dword [0x101b7f22], 0x1000000 */
            ii(0x100e_4b41, 10); mov(memd_a32[ds, 0x101b_7f1e], 0x100_0000); /* mov dword [0x101b7f1e], 0x1000000 */
        l_0x100e_4b4b:
            ii(0x100e_4b4b, 5); mov(edx, 0x1000);                       /* mov edx, 0x1000 */
            ii(0x100e_4b50, 5); mov(eax, /* sys */ 0x1016_c9d0);        /* mov eax, 0x1016c9d0 */
            ii(0x100e_4b55, 5); calld(0x100e_46e6, -0x474);             /* call 0x100e46e6 */
            ii(0x100e_4b5a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_4b5c, 2); if(jnzd(0x100e_4b76, 0x18)) goto l_0x100e_4b76; /* jnz 0x100e4b76 */
            ii(0x100e_4b5e, 5); mov(eax, StringDefinitions.ErrorLockingGetds); /* mov eax, 0x101a1cdb */
            ii(0x100e_4b63, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4b64, 5); calld(Definitions.sys_printf, 0x8_7ad3); /* call 0x1016c63c */
            ii(0x100e_4b69, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x100e_4b6c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_4b71, 5); calld(Definitions.sys_exit, 0x8_7ae9);  /* call 0x1016c65f */
        l_0x100e_4b76:
            ii(0x100e_4b76, 5); mov(edx, 0x1000);                       /* mov edx, 0x1000 */
            ii(0x100e_4b7b, 5); mov(eax, /* sys */ 0x1016_c704);        /* mov eax, 0x1016c704 */
            ii(0x100e_4b80, 5); calld(0x100e_46e6, -0x49f);             /* call 0x100e46e6 */
            ii(0x100e_4b85, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_4b87, 2); if(jnzd(0x100e_4ba1, 0x18)) goto l_0x100e_4ba1; /* jnz 0x100e4ba1 */
            ii(0x100e_4b89, 5); mov(eax, StringDefinitions.ErrorLockingCstart); /* mov eax, 0x101a1cf0 */
            ii(0x100e_4b8e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4b8f, 5); calld(Definitions.sys_printf, 0x8_7aa8); /* call 0x1016c63c */
            ii(0x100e_4b94, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x100e_4b97, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_4b9c, 5); calld(Definitions.sys_exit, 0x8_7abe);  /* call 0x1016c65f */
        l_0x100e_4ba1:
            ii(0x100e_4ba1, 5); mov(edx, 0x1000);                       /* mov edx, 0x1000 */
            ii(0x100e_4ba6, 5); mov(eax, /* sys */ 0x1016_c9dc);        /* mov eax, 0x1016c9dc */
            ii(0x100e_4bab, 5); calld(0x100e_46e6, -0x4ca);             /* call 0x100e46e6 */
            ii(0x100e_4bb0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_4bb2, 2); if(jnzd(0x100e_4bcc, 0x18)) goto l_0x100e_4bcc; /* jnz 0x100e4bcc */
            ii(0x100e_4bb4, 5); mov(eax, StringDefinitions.ErrorLockingChainIntr); /* mov eax, 0x101a1d05 */
            ii(0x100e_4bb9, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4bba, 5); calld(Definitions.sys_printf, 0x8_7a7d); /* call 0x1016c63c */
            ii(0x100e_4bbf, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x100e_4bc2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_4bc7, 5); calld(Definitions.sys_exit, 0x8_7a93);  /* call 0x1016c65f */
        l_0x100e_4bcc:
            ii(0x100e_4bcc, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
            ii(0x100e_4bd3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_4bd6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4bd8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_4bd9, 1); popd(edi);                              /* pop edi */
            ii(0x100e_4bda, 1); popd(esi);                              /* pop esi */
            ii(0x100e_4bdb, 1); popd(edx);                              /* pop edx */
            ii(0x100e_4bdc, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_4bdd, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_4bde, 1); retd(); return;                         /* ret */
        }
    }
}
