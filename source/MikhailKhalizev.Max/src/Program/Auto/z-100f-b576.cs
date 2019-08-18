using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("144d829f-a034-487a-83a6-e29661c55340")]
        public void Method_100f_b576()
        {
            ii(0x100f_b576, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_b57b, 5); calld(Definitions.sys_check_available_stack_size, 0x6_a7d2); /* call 0x10165d52 */
            ii(0x100f_b580, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_b581, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_b582, 1); pushd(edx);                             /* push edx */
            ii(0x100f_b583, 1); pushd(esi);                             /* push esi */
            ii(0x100f_b584, 1); pushd(edi);                             /* push edi */
            ii(0x100f_b585, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_b586, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_b588, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_b58e, 7); mov(memb_a32[ds, 0x101c_39b0], 0);      /* mov byte [0x101c39b0], 0x0 */
            ii(0x100f_b595, 5); mov(eax, 0x36);                         /* mov eax, 0x36 */
            ii(0x100f_b59a, 5); calld(0x1007_5fdc, -0x8_55c3);          /* call 0x10075fdc */
            ii(0x100f_b59f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_b5a1, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100f_b5a6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_b5a8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_b5ab, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_b5ad, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_b5b0, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100f_b5b5, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_b5ba, 5); calld(0x1013_d195, 0x4_1bd6);           /* call 0x1013d195 */
            ii(0x100f_b5bf, 5); calld(0x1013_44d5, 0x3_8f11);           /* call 0x101344d5 */
            ii(0x100f_b5c4, 5); mov(eax, 0x6be);                        /* mov eax, 0x6be */
            ii(0x100f_b5c9, 5); calld(0x100e_8ade, -0x1_2af0);          /* call 0x100e8ade */
            ii(0x100f_b5ce, 5); calld(0x1015_aa72, 0x5_f49f);           /* call 0x1015aa72 */
            ii(0x100f_b5d3, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_b5da, 2); jmpd(0x100f_b5e2, 0x6); goto l_0x100f_b5e2; /* jmp 0x100fb5e2 */
        l_0x100f_b5dc:
            ii(0x100f_b5dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_b5df, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x100f_b5e2:
            ii(0x100f_b5e2, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b5e6, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100f_b5e9, 2); if(jged(0x100f_b613, 0x28)) goto l_0x100f_b613; /* jge 0x100fb613 */
            ii(0x100f_b5eb, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_b5ef, 3); imul(edx, edx, 0x2b);                   /* imul edx, edx, 0x2b */
            ii(0x100f_b5f2, 5); mov(eax, 0x101c_94c8);                  /* mov eax, 0x101c94c8 */
            ii(0x100f_b5f7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_b5f9, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b5fd, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_b600, 5); mov(ebx, 0x101c_81c0);                  /* mov ebx, 0x101c81c0 */
            ii(0x100f_b605, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100f_b607, 5); calld(0x100e_90e1, -0x1_252b);          /* call 0x100e90e1 */
            ii(0x100f_b60c, 5); calld(0x100e_a7e7, -0x1_0e2a);          /* call 0x100ea7e7 */
            ii(0x100f_b611, 2); jmpd(0x100f_b5dc, -0x37); goto l_0x100f_b5dc; /* jmp 0x100fb5dc */
        l_0x100f_b613:
            ii(0x100f_b613, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
        l_0x100f_b61a:
            ii(0x100f_b61a, 3); dec(memd_a32[ss, ebp - 0x4]);           /* dec dword [ebp-0x4] */
            ii(0x100f_b61d, 5); cmp(memw_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x100f_b622, 2); if(jzd(0x100f_b62f, 0xb)) goto l_0x100f_b62f; /* jz 0x100fb62f */
            ii(0x100f_b624, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b628, 5); calld(0x1013_602e, 0x3_aa01);           /* call 0x1013602e */
            ii(0x100f_b62d, 2); jmpd(0x100f_b61a, -0x15); goto l_0x100f_b61a; /* jmp 0x100fb61a */
        l_0x100f_b62f:
            ii(0x100f_b62f, 7); mov(memd_a32[ss, ebp - 0x4], 0x4);      /* mov dword [ebp-0x4], 0x4 */
        l_0x100f_b636:
            ii(0x100f_b636, 3); dec(memd_a32[ss, ebp - 0x4]);           /* dec dword [ebp-0x4] */
            ii(0x100f_b639, 5); cmp(memw_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x100f_b63e, 2); if(jzd(0x100f_b64d, 0xd)) goto l_0x100f_b64d; /* jz 0x100fb64d */
            ii(0x100f_b640, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b644, 7); mov(memb_a32[ds, eax + 0x101c_3934], 0x1); /* mov byte [eax+0x101c3934], 0x1 */
            ii(0x100f_b64b, 2); jmpd(0x100f_b636, -0x17); goto l_0x100f_b636; /* jmp 0x100fb636 */
        l_0x100f_b64d:
            ii(0x100f_b64d, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_b654, 2); jmpd(0x100f_b65c, 0x6); goto l_0x100f_b65c; /* jmp 0x100fb65c */
        l_0x100f_b656:
            ii(0x100f_b656, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_b659, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x100f_b65c:
            ii(0x100f_b65c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b660, 3); cmp(eax, 0x18);                         /* cmp eax, 0x18 */
            ii(0x100f_b663, 2); if(jaed(0x100f_b675, 0x10)) goto l_0x100f_b675; /* jae 0x100fb675 */
            ii(0x100f_b665, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b669, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_b66c, 7); mov(memb_a32[ds, eax + 0x101b_8757], 0); /* mov byte [eax+0x101b8757], 0x0 */
            ii(0x100f_b673, 2); jmpd(0x100f_b656, -0x1f); goto l_0x100f_b656; /* jmp 0x100fb656 */
        l_0x100f_b675:
            ii(0x100f_b675, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_b67c, 2); if(jzd(0x100f_b68c, 0xe)) goto l_0x100f_b68c; /* jz 0x100fb68c */
            ii(0x100f_b67e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_b680, 5); calld(/* sys */ 0x1017_8f78, 0x7_d8f3); /* call 0x10178f78 */
            ii(0x100f_b685, 5); calld(/* sys */ 0x1016_5ebf, 0x6_a835); /* call 0x10165ebf */
            ii(0x100f_b68a, 2); jmpd(0x100f_b6a2, 0x16); goto l_0x100f_b6a2; /* jmp 0x100fb6a2 */
        l_0x100f_b68c:
            ii(0x100f_b68c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_b68e, 5); calld(/* sys */ 0x1017_8f78, 0x7_d8e5); /* call 0x10178f78 */
            ii(0x100f_b693, 5); mov(memd_a32[ds, 0x101c_5628], eax);    /* mov [0x101c5628], eax */
            ii(0x100f_b698, 5); mov(eax, memd_a32[ds, 0x101c_5628]);    /* mov eax, [0x101c5628] */
            ii(0x100f_b69d, 5); calld(/* sys */ 0x1016_5ebf, 0x6_a81d); /* call 0x10165ebf */
        l_0x100f_b6a2:
            ii(0x100f_b6a2, 10); mov(memd_a32[ds, 0x101c_38c8], 0xff);  /* mov dword [0x101c38c8], 0xff */
            ii(0x100f_b6ac, 7); mov(memb_a32[ds, 0x101c_3970], 0);      /* mov byte [0x101c3970], 0x0 */
            ii(0x100f_b6b3, 7); mov(memb_a32[ds, 0x101c_3888], 0);      /* mov byte [0x101c3888], 0x0 */
            ii(0x100f_b6ba, 7); mov(memb_a32[ds, 0x101c_388c], 0);      /* mov byte [0x101c388c], 0x0 */
            ii(0x100f_b6c1, 7); mov(memb_a32[ds, 0x101c_388a], 0);      /* mov byte [0x101c388a], 0x0 */
            ii(0x100f_b6c8, 7); mov(memb_a32[ds, 0x101c_3889], 0);      /* mov byte [0x101c3889], 0x0 */
            ii(0x100f_b6cf, 7); mov(memb_a32[ds, 0x101c_388d], 0);      /* mov byte [0x101c388d], 0x0 */
            ii(0x100f_b6d6, 7); mov(memb_a32[ds, 0x101c_388e], 0);      /* mov byte [0x101c388e], 0x0 */
            ii(0x100f_b6dd, 7); mov(memb_a32[ds, 0x101c_37cc], 0);      /* mov byte [0x101c37cc], 0x0 */
            ii(0x100f_b6e4, 7); mov(memb_a32[ds, 0x101c_37cd], 0);      /* mov byte [0x101c37cd], 0x0 */
            ii(0x100f_b6eb, 7); mov(memb_a32[ds, 0x101c_37ce], 0);      /* mov byte [0x101c37ce], 0x0 */
            ii(0x100f_b6f2, 7); mov(memb_a32[ds, 0x101c_37cf], 0);      /* mov byte [0x101c37cf], 0x0 */
            ii(0x100f_b6f9, 7); mov(memb_a32[ds, 0x101c_37cb], 0);      /* mov byte [0x101c37cb], 0x0 */
            ii(0x100f_b700, 7); mov(memb_a32[ds, 0x101c_37d0], 0);      /* mov byte [0x101c37d0], 0x0 */
            ii(0x100f_b707, 7); mov(memb_a32[ds, 0x101c_37d1], 0);      /* mov byte [0x101c37d1], 0x0 */
            ii(0x100f_b70e, 7); mov(memb_a32[ds, 0x101c_388b], 0);      /* mov byte [0x101c388b], 0x0 */
            ii(0x100f_b715, 7); mov(memb_a32[ds, 0x101c_388f], 0x1);    /* mov byte [0x101c388f], 0x1 */
            ii(0x100f_b71c, 7); mov(memb_a32[ds, 0x101c_37d2], 0);      /* mov byte [0x101c37d2], 0x0 */
            ii(0x100f_b723, 7); mov(memb_a32[ds, 0x101c_3890], 0);      /* mov byte [0x101c3890], 0x0 */
            ii(0x100f_b72a, 7); mov(memb_a32[ds, 0x101c_3984], 0);      /* mov byte [0x101c3984], 0x0 */
            ii(0x100f_b731, 7); mov(memb_a32[ds, 0x101c_37d3], 0x1);    /* mov byte [0x101c37d3], 0x1 */
            ii(0x100f_b738, 7); mov(memb_a32[ds, 0x101c_38a2], 0);      /* mov byte [0x101c38a2], 0x0 */
            ii(0x100f_b73f, 7); mov(memb_a32[ds, 0x101c_38a3], 0);      /* mov byte [0x101c38a3], 0x0 */
            ii(0x100f_b746, 7); mov(memb_a32[ds, 0x101c_391d], 0);      /* mov byte [0x101c391d], 0x0 */
            ii(0x100f_b74d, 7); mov(memb_a32[ds, 0x101c_3911], 0);      /* mov byte [0x101c3911], 0x0 */
            ii(0x100f_b754, 7); mov(memb_a32[ds, 0x101c_3913], 0);      /* mov byte [0x101c3913], 0x0 */
            ii(0x100f_b75b, 7); mov(memb_a32[ds, 0x101c_3910], 0);      /* mov byte [0x101c3910], 0x0 */
            ii(0x100f_b762, 7); mov(memb_a32[ds, 0x101c_37d4], 0);      /* mov byte [0x101c37d4], 0x0 */
            ii(0x100f_b769, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_b76e, 5); calld(0x1007_5fdc, -0x8_5797);          /* call 0x10075fdc */
            ii(0x100f_b773, 5); mov(memb_a32[ds, 0x101c_3920], al);     /* mov [0x101c3920], al */
            ii(0x100f_b778, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100f_b77d, 5); calld(0x1007_5fdc, -0x8_57a6);          /* call 0x10075fdc */
            ii(0x100f_b782, 5); mov(memb_a32[ds, 0x101c_3915], al);     /* mov [0x101c3915], al */
            ii(0x100f_b787, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100f_b78c, 5); calld(0x1007_5fdc, -0x8_57b5);          /* call 0x10075fdc */
            ii(0x100f_b791, 5); mov(memb_a32[ds, 0x101c_37c9], al);     /* mov [0x101c37c9], al */
            ii(0x100f_b796, 5); mov(eax, 0x55);                         /* mov eax, 0x55 */
            ii(0x100f_b79b, 5); calld(0x1007_5fdc, -0x8_57c4);          /* call 0x10075fdc */
            ii(0x100f_b7a0, 5); mov(memb_a32[ds, 0x101c_37ca], al);     /* mov [0x101c37ca], al */
            ii(0x100f_b7a5, 9); mov(memw_a32[ds, 0x101c_3900], 0);      /* mov word [0x101c3900], 0x0 */
            ii(0x100f_b7ae, 10); mov(memd_a32[ds, 0x101c_3904], 0);     /* mov dword [0x101c3904], 0x0 */
            ii(0x100f_b7b8, 10); mov(memd_a32[ds, 0x101c_37dc], 0x1);   /* mov dword [0x101c37dc], 0x1 */
            ii(0x100f_b7c2, 9); mov(memw_a32[ds, 0x101c_38e2], 0);      /* mov word [0x101c38e2], 0x0 */
            ii(0x100f_b7cb, 9); mov(memw_a32[ds, 0x101c_38e4], 0);      /* mov word [0x101c38e4], 0x0 */
            ii(0x100f_b7d4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_b7d6, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_b7db, 5); calld(0x1007_6630, -0x8_51b0);          /* call 0x10076630 */
            ii(0x100f_b7e0, 7); mov(memb_a32[ds, 0x101c_37e4], 0);      /* mov byte [0x101c37e4], 0x0 */
            ii(0x100f_b7e7, 10); mov(memd_a32[ds, 0x101c_39ac], 0);     /* mov dword [0x101c39ac], 0x0 */
            ii(0x100f_b7f1, 9); mov(memw_a32[ds, 0x101c_3962], 0);      /* mov word [0x101c3962], 0x0 */
            ii(0x100f_b7fa, 9); mov(memw_a32[ds, 0x101c_38ba], 0xffff); /* mov word [0x101c38ba], 0xffff */
            ii(0x100f_b803, 6); mov(ax, memw_a32[ds, 0x101c_38ba]);     /* mov ax, [0x101c38ba] */
            ii(0x100f_b809, 6); mov(memw_a32[ds, 0x101c_38b8], ax);     /* mov [0x101c38b8], ax */
            ii(0x100f_b80f, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_b814, 5); calld(0x1013_a6f4, 0x3_eedb);           /* call 0x1013a6f4 */
            ii(0x100f_b819, 9); mov(memw_a32[ds, 0x101c_7120], 0xffff); /* mov word [0x101c7120], 0xffff */
            ii(0x100f_b822, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_b824, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_b825, 1); popd(edi);                              /* pop edi */
            ii(0x100f_b826, 1); popd(esi);                              /* pop esi */
            ii(0x100f_b827, 1); popd(edx);                              /* pop edx */
            ii(0x100f_b828, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_b829, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_b82a, 1); retd(); return;                         /* ret */
        }
    }
}
