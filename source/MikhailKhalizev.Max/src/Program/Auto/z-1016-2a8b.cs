using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5646a3e6-aeb6-4a33-b7cc-4c5805a20026")]
        public void Method_1016_2a8b()
        {
            ii(0x1016_2a8b, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1016_2a90, 5); calld(Definitions.sys_check_available_stack_size, 0x32bd); /* call 0x10165d52 */
            ii(0x1016_2a95, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_2a96, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_2a97, 1); pushd(edx);                             /* push edx */
            ii(0x1016_2a98, 1); pushd(esi);                             /* push esi */
            ii(0x1016_2a99, 1); pushd(edi);                             /* push edi */
            ii(0x1016_2a9a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_2a9b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_2a9d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_2aa3, 7); cmp(memb_a32[ds, 0x101c_b0fe], 0);      /* cmp byte [0x101cb0fe], 0x0 */
            ii(0x1016_2aaa, 2); if(jnzd(0x1016_2af5, 0x49)) goto l_0x1016_2af5; /* jnz 0x10162af5 */
            ii(0x1016_2aac, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1016_2ab3, 2); jmpd(0x1016_2abb, 0x6); goto l_0x1016_2abb; /* jmp 0x10162abb */
        l_0x1016_2ab5:
            ii(0x1016_2ab5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2ab8, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x1016_2abb:
            ii(0x1016_2abb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_2abf, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x1016_2ac2, 2); if(jged(0x1016_2ae7, 0x23)) goto l_0x1016_2ae7; /* jge 0x10162ae7 */
            ii(0x1016_2ac4, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_2ac8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_2acb, 10); mov(memd_a32[ds, eax + 0x101c_b084], 0xaae6); /* mov dword [eax+0x101cb084], 0xaae6 */
            ii(0x1016_2ad5, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1016_2ad9, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1016_2adb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2ade, 7); mov(memw_a32[ds, edx + 0x101c_b0d4], ax); /* mov [edx+0x101cb0d4], ax */
            ii(0x1016_2ae5, 2); jmpd(0x1016_2ab5, -0x32); goto l_0x1016_2ab5; /* jmp 0x10162ab5 */
        l_0x1016_2ae7:
            ii(0x1016_2ae7, 7); mov(memb_a32[ds, 0x101c_b0fe], 0x1);    /* mov byte [0x101cb0fe], 0x1 */
            ii(0x1016_2aee, 7); mov(memb_a32[ds, 0x101c_3978], 0);      /* mov byte [0x101c3978], 0x0 */
        l_0x1016_2af5:
            ii(0x1016_2af5, 7); cmp(memb_a32[ds, 0x101c_3978], 0);      /* cmp byte [0x101c3978], 0x0 */
            ii(0x1016_2afc, 6); if(jnzd(0x1016_2caf, 0x1ad)) goto l_0x1016_2caf; /* jnz 0x10162caf */
            ii(0x1016_2b02, 5); mov(eax, memd_a32[ds, 0x101c_b0fa]);    /* mov eax, [0x101cb0fa] */
            ii(0x1016_2b07, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_2b0a, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_2b0c, 7); mov(ax, memw_a32[ds, eax + 0x101c_b0d4]); /* mov ax, [eax+0x101cb0d4] */
            ii(0x1016_2b13, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_2b16, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_2b1a, 3); cmp(eax, 0x13);                         /* cmp eax, 0x13 */
            ii(0x1016_2b1d, 2); if(jged(0x1016_2b50, 0x31)) goto l_0x1016_2b50; /* jge 0x10162b50 */
            ii(0x1016_2b1f, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1016_2b23, 5); mov(eax, 0x13);                         /* mov eax, 0x13 */
            ii(0x1016_2b28, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_2b2a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_2b2c, 2); add(ebx, ebx);                          /* add ebx, ebx */
            ii(0x1016_2b2e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_2b32, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_2b34, 5); mov(edx, 0x101c_b0d4);                  /* mov edx, 0x101cb0d4 */
            ii(0x1016_2b39, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_2b3b, 3); lea(edx, eax + 0x2);                    /* lea edx, [eax+0x2] */
            ii(0x1016_2b3e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_2b42, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_2b44, 5); mov(ecx, 0x101c_b0d4);                  /* mov ecx, 0x101cb0d4 */
            ii(0x1016_2b49, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_2b4b, 5); calld(/* sys */ 0x1016_6177, 0x3627);   /* call 0x10166177 */
        l_0x1016_2b50:
            ii(0x1016_2b50, 5); calld(0x1014_82f4, -0x1_a861);          /* call 0x101482f4 */
            ii(0x1016_2b55, 6); sub(eax, memd_a32[ds, 0x101c_3974]);    /* sub eax, [0x101c3974] */
            ii(0x1016_2b5b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_2b5e, 7); cmp(memd_a32[ss, ebp - 0xc], 0x12_34dc); /* cmp dword [ebp-0xc], 0x1234dc */
            ii(0x1016_2b65, 2); if(jbed(0x1016_2b6e, 0x7)) goto l_0x1016_2b6e; /* jbe 0x10162b6e */
            ii(0x1016_2b67, 7); mov(memd_a32[ss, ebp - 0xc], 0x12_34dc); /* mov dword [ebp-0xc], 0x1234dc */
        l_0x1016_2b6e:
            ii(0x1016_2b6e, 6); mov(edx, memd_a32[ds, 0x101c_b0fa]);    /* mov edx, [0x101cb0fa] */
            ii(0x1016_2b74, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_2b77, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1016_2b7a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_2b7d, 6); mov(memd_a32[ds, edx + 0x101c_b084], eax); /* mov [edx+0x101cb084], eax */
            ii(0x1016_2b83, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1016_2b8a:
            ii(0x1016_2b8a, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_2b8e, 3); cmp(eax, 0x13);                         /* cmp eax, 0x13 */
            ii(0x1016_2b91, 2); if(jged(0x1016_2bb0, 0x1d)) goto l_0x1016_2bb0; /* jge 0x10162bb0 */
            ii(0x1016_2b93, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_2b97, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_2b99, 6); mov(eax, memd_a32[ds, eax + 0x101c_b0d2]); /* mov eax, [eax+0x101cb0d2] */
            ii(0x1016_2b9f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_2ba2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_2ba5, 6); mov(eax, memd_a32[ds, eax + 0x101c_b084]); /* mov eax, [eax+0x101cb084] */
            ii(0x1016_2bab, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1016_2bae, 2); if(jbd(0x1016_2bb2, 0x2)) goto l_0x1016_2bb2; /* jb 0x10162bb2 */
        l_0x1016_2bb0:
            ii(0x1016_2bb0, 2); jmpd(0x1016_2bba, 0x8); goto l_0x1016_2bba; /* jmp 0x10162bba */
        l_0x1016_2bb2:
            ii(0x1016_2bb2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2bb5, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
            ii(0x1016_2bb8, 2); jmpd(0x1016_2b8a, -0x30); goto l_0x1016_2b8a; /* jmp 0x10162b8a */
        l_0x1016_2bba:
            ii(0x1016_2bba, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_2bbe, 3); cmp(eax, 0x13);                         /* cmp eax, 0x13 */
            ii(0x1016_2bc1, 2); if(jged(0x1016_2bf6, 0x33)) goto l_0x1016_2bf6; /* jge 0x10162bf6 */
            ii(0x1016_2bc3, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1016_2bc7, 5); mov(eax, 0x13);                         /* mov eax, 0x13 */
            ii(0x1016_2bcc, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_2bce, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_2bd0, 2); add(ebx, ebx);                          /* add ebx, ebx */
            ii(0x1016_2bd2, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1016_2bd6, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1016_2bd8, 5); mov(eax, 0x101c_b0d4);                  /* mov eax, 0x101cb0d4 */
            ii(0x1016_2bdd, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_2bdf, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_2be3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_2be5, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_2be7, 5); mov(eax, 0x101c_b0d4);                  /* mov eax, 0x101cb0d4 */
            ii(0x1016_2bec, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_2bee, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1016_2bf1, 5); calld(/* sys */ 0x1016_6177, 0x3581);   /* call 0x10166177 */
        l_0x1016_2bf6:
            ii(0x1016_2bf6, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1016_2bfa, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1016_2bfc, 7); mov(bx, memw_a32[ds, 0x101c_b0fc]);     /* mov bx, [0x101cb0fc] */
            ii(0x1016_2c03, 7); mov(memw_a32[ds, edx + 0x101c_b0d4], bx); /* mov [edx+0x101cb0d4], bx */
            ii(0x1016_2c0a, 6); mov(edx, memd_a32[ds, 0x101c_b0fa]);    /* mov edx, [0x101cb0fa] */
            ii(0x1016_2c10, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_2c13, 1); inc(edx);                               /* inc edx */
            ii(0x1016_2c14, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x1016_2c19, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_2c1b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_2c1e, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1016_2c20, 7); mov(memw_a32[ds, 0x101c_b0fc], dx);     /* mov [0x101cb0fc], dx */
            ii(0x1016_2c27, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1016_2c2a, 3); lea(edx, edx + edx * 2);                /* lea edx, [edx+edx*2] */
            ii(0x1016_2c2d, 2); shr(edx, 0x1);                          /* shr edx, 1 */
            ii(0x1016_2c2f, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1016_2c32, 7); cmp(memd_a32[ss, ebp - 0x10], 0x5d37);  /* cmp dword [ebp-0x10], 0x5d37 */
            ii(0x1016_2c39, 2); if(jaed(0x1016_2c42, 0x7)) goto l_0x1016_2c42; /* jae 0x10162c42 */
            ii(0x1016_2c3b, 7); mov(memd_a32[ss, ebp - 0x10], 0x5d37);  /* mov dword [ebp-0x10], 0x5d37 */
        l_0x1016_2c42:
            ii(0x1016_2c42, 7); cmp(memd_a32[ss, ebp - 0x10], 0x9b5c);  /* cmp dword [ebp-0x10], 0x9b5c */
            ii(0x1016_2c49, 2); if(jbed(0x1016_2c52, 0x7)) goto l_0x1016_2c52; /* jbe 0x10162c52 */
            ii(0x1016_2c4b, 7); mov(memd_a32[ss, ebp - 0x10], 0x9b5c);  /* mov dword [ebp-0x10], 0x9b5c */
        l_0x1016_2c52:
            ii(0x1016_2c52, 5); mov(eax, memd_a32[ds, 0x101c_b0e6]);    /* mov eax, [0x101cb0e6] */
            ii(0x1016_2c57, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_2c5a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_2c5d, 6); mov(eax, memd_a32[ds, eax + 0x101c_b084]); /* mov eax, [eax+0x101cb084] */
            ii(0x1016_2c63, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_2c66, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_2c69, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1016_2c6c, 5); mov(memd_a32[ds, 0x101b_dd84], eax);    /* mov [0x101bdd84], eax */
            ii(0x1016_2c71, 7); cmp(memd_a32[ss, ebp - 0xc], 0x9b5c);   /* cmp dword [ebp-0xc], 0x9b5c */
            ii(0x1016_2c78, 2); if(jaed(0x1016_2c83, 0x9)) goto l_0x1016_2c83; /* jae 0x10162c83 */
            ii(0x1016_2c7a, 7); add(memd_a32[ss, ebp - 0xc], 0x9b5c);   /* add dword [ebp-0xc], 0x9b5c */
            ii(0x1016_2c81, 2); jmpd(0x1016_2c86, 0x3); goto l_0x1016_2c86; /* jmp 0x10162c86 */
        l_0x1016_2c83:
            ii(0x1016_2c83, 3); shl(memd_a32[ss, ebp - 0xc], 0x1);      /* shl dword [ebp-0xc], 1 */
        l_0x1016_2c86:
            ii(0x1016_2c86, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_2c89, 6); cmp(eax, memd_a32[ds, 0x101b_dd84]);    /* cmp eax, [0x101bdd84] */
            ii(0x1016_2c8f, 2); if(jaed(0x1016_2c99, 0x8)) goto l_0x1016_2c99; /* jae 0x10162c99 */
            ii(0x1016_2c91, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_2c94, 5); mov(memd_a32[ds, 0x101b_dd84], eax);    /* mov [0x101bdd84], eax */
        l_0x1016_2c99:
            ii(0x1016_2c99, 10); cmp(memd_a32[ds, 0x101b_dd84], 0xaae6); /* cmp dword [0x101bdd84], 0xaae6 */
            ii(0x1016_2ca3, 2); if(jaed(0x1016_2caf, 0xa)) goto l_0x1016_2caf; /* jae 0x10162caf */
            ii(0x1016_2ca5, 10); mov(memd_a32[ds, 0x101b_dd84], 0xaae6); /* mov dword [0x101bdd84], 0xaae6 */
        l_0x1016_2caf:
            ii(0x1016_2caf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_2cb1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_2cb2, 1); popd(edi);                              /* pop edi */
            ii(0x1016_2cb3, 1); popd(esi);                              /* pop esi */
            ii(0x1016_2cb4, 1); popd(edx);                              /* pop edx */
            ii(0x1016_2cb5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_2cb6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_2cb7, 1); retd(); return;                         /* ret */
        }
    }
}
