using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_0efe-ebfd8b8d")]
        public void Method_1010_0efe()
        {
            ii(0x1010_0efe, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1010_0f03, 5); calld(Definitions.sys_check_available_stack_size, 0x6_4e4a); /* call 0x10165d52 */
            ii(0x1010_0f08, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_0f09, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_0f0a, 1); pushd(edx);                             /* push edx */
            ii(0x1010_0f0b, 1); pushd(esi);                             /* push esi */
            ii(0x1010_0f0c, 1); pushd(edi);                             /* push edi */
            ii(0x1010_0f0d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_0f0e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_0f10, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1010_0f16, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_0f19, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1010_0f1d, 5); cmp(memw_a32[ss, ebp - 0x4], 0);        /* cmp word [ebp-0x4], 0x0 */
            ii(0x1010_0f22, 2); if(jzd(0x1010_0f29, 0x5)) goto l_0x1010_0f29; /* jz 0x10100f29 */
            ii(0x1010_0f24, 5); calld(0x100f_f5c1, -0x1968);            /* call 0x100ff5c1 */
        l_0x1010_0f29:
            ii(0x1010_0f29, 5); calld(0x1010_0da4, -0x18a);             /* call 0x10100da4 */
            ii(0x1010_0f2e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_0f30, 2); if(jzd(0x1010_0f48, 0x16)) goto l_0x1010_0f48; /* jz 0x10100f48 */
            ii(0x1010_0f32, 5); calld(0x1010_2aac, 0x1b75);             /* call 0x10102aac */
            ii(0x1010_0f37, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0f39, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1010_0f3b, 5); mov(eax, memd_a32[ds, 0x101c_3960]);    /* mov eax, [0x101c3960] */
            ii(0x1010_0f40, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0f43, 5); calld(0x100f_334b, -0xdbfd);            /* call 0x100f334b */
        l_0x1010_0f48:
            ii(0x1010_0f48, 7); cmp(memd_a32[ds, 0x101c_37e0], 0);      /* cmp dword [0x101c37e0], 0x0 */
            ii(0x1010_0f4f, 2); if(jzd(0x1010_0f5a, 0x9)) goto l_0x1010_0f5a; /* jz 0x10100f5a */
            ii(0x1010_0f51, 7); cmp(memb_a32[ds, 0x101c_3911], 0);      /* cmp byte [0x101c3911], 0x0 */
            ii(0x1010_0f58, 2); if(jnzd(0x1010_0f5c, 0x2)) goto l_0x1010_0f5c; /* jnz 0x10100f5c */
        l_0x1010_0f5a:
            ii(0x1010_0f5a, 2); jmpd(0x1010_0f6a, 0xe); goto l_0x1010_0f6a; /* jmp 0x10100f6a */
        l_0x1010_0f5c:
            ii(0x1010_0f5c, 5); mov(eax, 0x52);                         /* mov eax, 0x52 */
            ii(0x1010_0f61, 5); calld(0x1007_5fdc, -0x8_af8a);          /* call 0x10075fdc */
            ii(0x1010_0f66, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_0f68, 2); if(jnzd(0x1010_0f6c, 0x2)) goto l_0x1010_0f6c; /* jnz 0x10100f6c */
        l_0x1010_0f6a:
            ii(0x1010_0f6a, 2); jmpd(0x1010_0f9b, 0x2f); goto l_0x1010_0f9b; /* jmp 0x10100f9b */
        l_0x1010_0f6c:
            ii(0x1010_0f6c, 5); calld(0x1014_82f4, 0x4_7383);           /* call 0x101482f4 */
            ii(0x1010_0f71, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_0f74, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_0f77, 6); sub(eax, memd_a32[ds, 0x101c_397c]);    /* sub eax, [0x101c397c] */
            ii(0x1010_0f7d, 5); cmp(eax, 0x1_36b9);                     /* cmp eax, 0x136b9 */
            ii(0x1010_0f82, 2); if(jbd(0x1010_0f9b, 0x17)) goto l_0x1010_0f9b; /* jb 0x10100f9b */
            ii(0x1010_0f84, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_0f87, 5); mov(memd_a32[ds, 0x101c_397c], eax);    /* mov [0x101c397c], eax */
            ii(0x1010_0f8c, 5); mov(eax, memd_a32[ds, 0x101c_37e0]);    /* mov eax, [0x101c37e0] */
            ii(0x1010_0f91, 5); calld(0x100f_066e, -0x1_0928);          /* call 0x100f066e */
            ii(0x1010_0f96, 5); mov(memb_a32[ds, 0x101c_3911], al);     /* mov [0x101c3911], al */
        l_0x1010_0f9b:
            ii(0x1010_0f9b, 5); calld(0x1014_82f4, 0x4_7354);           /* call 0x101482f4 */
            ii(0x1010_0fa0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_0fa3, 7); mov(memd_a32[ss, ebp - 0xc], 0xb);      /* mov dword [ebp-0xc], 0xb */
        l_0x1010_0faa:
            ii(0x1010_0faa, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1010_0fad, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_0fb2, 2); if(jzd(0x1010_0fe9, 0x35)) goto l_0x1010_0fe9; /* jz 0x10100fe9 */
            ii(0x1010_0fb4, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_0fb8, 3); imul(eax, eax, 0xd);                    /* imul eax, eax, 0xd */
            ii(0x1010_0fbb, 5); mov(edx, 0x101b_89f8);                  /* mov edx, 0x101b89f8 */
            ii(0x1010_0fc0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_0fc2, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x1010_0fc5, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_0fc8, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_0fcb, 3); sub(edx, memd_a32[ds, eax + 0x9]);      /* sub edx, [eax+0x9] */
            ii(0x1010_0fce, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_0fd1, 3); cmp(edx, memd_a32[ds, eax + 0x5]);      /* cmp edx, [eax+0x5] */
            ii(0x1010_0fd4, 2); if(jbd(0x1010_0fe7, 0x11)) goto l_0x1010_0fe7; /* jb 0x10100fe7 */
            ii(0x1010_0fd6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_0fd9, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1010_0fdc, 3); mov(memd_a32[ds, edx + 0x9], eax);      /* mov [edx+0x9], eax */
            ii(0x1010_0fdf, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_0fe2, 5); calld(0x100f_1db2, -0xf235);            /* call 0x100f1db2 */
        l_0x1010_0fe7:
            ii(0x1010_0fe7, 2); jmpd(0x1010_0faa, -0x3f); goto l_0x1010_0faa; /* jmp 0x10100faa */
        l_0x1010_0fe9:
            ii(0x1010_0fe9, 5); calld(0x1014_82f4, 0x4_7306);           /* call 0x101482f4 */
            ii(0x1010_0fee, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_0ff1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_0ff4, 6); sub(eax, memd_a32[ds, 0x101c_3974]);    /* sub eax, [0x101c3974] */
            ii(0x1010_0ffa, 5); cmp(eax, 0xc233);                       /* cmp eax, 0xc233 */
            ii(0x1010_0fff, 2); if(jaed(0x1010_1049, 0x48)) goto l_0x1010_1049; /* jae 0x10101049 */
            ii(0x1010_1001, 5); cmp(memw_a32[ss, ebp - 0x4], 0);        /* cmp word [ebp-0x4], 0x0 */
            ii(0x1010_1006, 2); if(jnzd(0x1010_1011, 0x9)) goto l_0x1010_1011; /* jnz 0x10101011 */
            ii(0x1010_1008, 7); cmp(memb_a32[ds, 0x101c_38a3], 0);      /* cmp byte [0x101c38a3], 0x0 */
            ii(0x1010_100f, 2); if(jzd(0x1010_1013, 0x2)) goto l_0x1010_1013; /* jz 0x10101013 */
        l_0x1010_1011:
            ii(0x1010_1011, 2); jmpd(0x1010_102a, 0x17); goto l_0x1010_102a; /* jmp 0x1010102a */
        l_0x1010_1013:
            ii(0x1010_1013, 6); mov(edx, memd_a32[ds, 0x101c_3984]);    /* mov edx, [0x101c3984] */
            ii(0x1010_1019, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_101c, 5); mov(eax, memd_a32[ds, 0x101c_3986]);    /* mov eax, [0x101c3986] */
            ii(0x1010_1021, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_1024, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1010_1026, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_1028, 2); if(jzd(0x1010_102f, 0x5)) goto l_0x1010_102f; /* jz 0x1010102f */
        l_0x1010_102a:
            ii(0x1010_102a, 5); calld(0x100f_aa9e, -0x6591);            /* call 0x100faa9e */
        l_0x1010_102f:
            ii(0x1010_102f, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1010_1036, 2); if(jzd(0x1010_103d, 0x5)) goto l_0x1010_103d; /* jz 0x1010103d */
            ii(0x1010_1038, 5); calld(0x1012_8602, 0x2_75c5);           /* call 0x10128602 */
        l_0x1010_103d:
            ii(0x1010_103d, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1010_1044, 5); jmpd(0x1010_10f7, 0xae); goto l_0x1010_10f7; /* jmp 0x101010f7 */
        l_0x1010_1049:
            ii(0x1010_1049, 7); cmp(memb_a32[ds, 0x101c_39b0], 0);      /* cmp byte [0x101c39b0], 0x0 */
            ii(0x1010_1050, 2); if(jzd(0x1010_105e, 0xc)) goto l_0x1010_105e; /* jz 0x1010105e */
            ii(0x1010_1052, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_1054, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1010_1059, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1010_105c, 2); if(jnzd(0x1010_1060, 0x2)) goto l_0x1010_1060; /* jnz 0x10101060 */
        l_0x1010_105e:
            ii(0x1010_105e, 2); jmpd(0x1010_1065, 0x5); goto l_0x1010_1065; /* jmp 0x10101065 */
        l_0x1010_1060:
            ii(0x1010_1060, 5); calld(0x100f_5734, -0xb931);            /* call 0x100f5734 */
        l_0x1010_1065:
            ii(0x1010_1065, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1010_106c, 2); if(jzd(0x1010_107d, 0xf)) goto l_0x1010_107d; /* jz 0x1010107d */
            ii(0x1010_106e, 5); calld(0x1010_2a8c, 0x1a19);             /* call 0x10102a8c */
            ii(0x1010_1073, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_1078, 5); calld(0x1012_869d, 0x2_7620);           /* call 0x1012869d */
        l_0x1010_107d:
            ii(0x1010_107d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_1080, 5); mov(memd_a32[ds, 0x101c_3974], eax);    /* mov [0x101c3974], eax */
            ii(0x1010_1085, 7); mov(memb_a32[ds, 0x101c_3978], 0);      /* mov byte [0x101c3978], 0x0 */
            ii(0x1010_108c, 7); cmp(memb_a32[ds, 0x101c_391e], 0xb);    /* cmp byte [0x101c391e], 0xb */
            ii(0x1010_1093, 2); if(jzd(0x1010_109a, 0x5)) goto l_0x1010_109a; /* jz 0x1010109a */
            ii(0x1010_1095, 5); calld(0x1016_2cb8, 0x6_1c1e);           /* call 0x10162cb8 */
        l_0x1010_109a:
            ii(0x1010_109a, 5); calld(0x100f_aa9e, -0x6601);            /* call 0x100faa9e */
            ii(0x1010_109f, 7); cmp(memb_a32[ds, 0x101c_391e], 0xb);    /* cmp byte [0x101c391e], 0xb */
            ii(0x1010_10a6, 2); if(jzd(0x1010_10b1, 0x9)) goto l_0x1010_10b1; /* jz 0x101010b1 */
            ii(0x1010_10a8, 7); cmp(memb_a32[ds, 0x101c_9447], 0);      /* cmp byte [0x101c9447], 0x0 */
            ii(0x1010_10af, 2); if(jzd(0x1010_10b3, 0x2)) goto l_0x1010_10b3; /* jz 0x101010b3 */
        l_0x1010_10b1:
            ii(0x1010_10b1, 2); jmpd(0x1010_10f0, 0x3d); goto l_0x1010_10f0; /* jmp 0x101010f0 */
        l_0x1010_10b3:
            ii(0x1010_10b3, 5); calld(0x1016_2a8b, 0x6_19d3);           /* call 0x10162a8b */
            ii(0x1010_10b8, 7); cmp(memb_a32[ds, 0x101c_37b8], 0);      /* cmp byte [0x101c37b8], 0x0 */
            ii(0x1010_10bf, 2); if(jzd(0x1010_10c6, 0x5)) goto l_0x1010_10c6; /* jz 0x101010c6 */
            ii(0x1010_10c1, 5); calld(0x100a_9502, -0x5_7bc4);          /* call 0x100a9502 */
        l_0x1010_10c6:
            ii(0x1010_10c6, 7); cmp(memb_a32[ds, 0x101c_37b8], 0);      /* cmp byte [0x101c37b8], 0x0 */
            ii(0x1010_10cd, 2); if(jnzd(0x1010_10d5, 0x6)) goto l_0x1010_10d5; /* jnz 0x101010d5 */
            ii(0x1010_10cf, 4); mov(memb_a32[ss, ebp - 0x1c], 0x1);     /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1010_10d3, 2); jmpd(0x1010_10d9, 0x4); goto l_0x1010_10d9; /* jmp 0x101010d9 */
        l_0x1010_10d5:
            ii(0x1010_10d5, 4); mov(memb_a32[ss, ebp - 0x1c], 0);       /* mov byte [ebp-0x1c], 0x0 */
        l_0x1010_10d9:
            ii(0x1010_10d9, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x1010_10dc, 5); mov(memb_a32[ds, 0x101c_37b8], al);     /* mov [0x101c37b8], al */
            ii(0x1010_10e1, 5); calld(0x1011_fdcd, 0x1_ece7);           /* call 0x1011fdcd */
            ii(0x1010_10e6, 5); calld(0x100a_9502, -0x5_7be9);          /* call 0x100a9502 */
            ii(0x1010_10eb, 5); calld(0x100a_8bbd, -0x5_8533);          /* call 0x100a8bbd */
        l_0x1010_10f0:
            ii(0x1010_10f0, 7); mov(memd_a32[ss, ebp - 0x18], 0x1);     /* mov dword [ebp-0x18], 0x1 */
        l_0x1010_10f7:
            ii(0x1010_10f7, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_10fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_10fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_10fd, 1); popd(edi);                              /* pop edi */
            ii(0x1010_10fe, 1); popd(esi);                              /* pop esi */
            ii(0x1010_10ff, 1); popd(edx);                              /* pop edx */
            ii(0x1010_1100, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_1101, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_1102, 1); retd(); return;                         /* ret */
        }
    }
}
