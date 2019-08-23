using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_8f02-a884dcb2")]
        public void Method_1012_8f02()
        {
            ii(0x1012_8f02, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1012_8f07, 5); calld(Definitions.sys_check_available_stack_size, 0x3_ce46); /* call 0x10165d52 */
            ii(0x1012_8f0c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_8f0d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_8f0e, 1); pushd(edx);                             /* push edx */
            ii(0x1012_8f0f, 1); pushd(esi);                             /* push esi */
            ii(0x1012_8f10, 1); pushd(edi);                             /* push edi */
            ii(0x1012_8f11, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_8f12, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_8f14, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1012_8f1a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_8f1d, 7); mov(memd_a32[ss, ebp - 0xc], 0x101c_5c21); /* mov dword [ebp-0xc], 0x101c5c21 */
            ii(0x1012_8f24, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_8f28, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1012_8f2b, 5); mov(edx, 0x101c_35b4);                  /* mov edx, 0x101c35b4 */
            ii(0x1012_8f30, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_8f32, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1012_8f35, 5); calld(0x1009_cb74, -0x8_c3c6);          /* call 0x1009cb74 */
            ii(0x1012_8f3a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_8f3c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1012_8f3e, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_8f41, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_8f44, 5); calld(0x1009_cab0, -0x8_c499);          /* call 0x1009cab0 */
            ii(0x1012_8f49, 5); calld(0x100e_0a00, -0x4_854e);          /* call 0x100e0a00 */
            ii(0x1012_8f4e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_8f50, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1012_8f52, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_8f55, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1012_8f58, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_8f5b, 5); calld(0x100e_0970, -0x4_85f0);          /* call 0x100e0970 */
            ii(0x1012_8f60, 7); mov(memb_a32[ds, 0x101c_5c1c], 0xc);    /* mov byte [0x101c5c1c], 0xc */
            ii(0x1012_8f67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_8f6a, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_8f70, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_8f73, 5); calld(Definitions.my_2_get_count, -0x9_dc10); /* call 0x1008b368 */
            ii(0x1012_8f78, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_8f7b, 5); add(eax, 0xd);                          /* add eax, 0xd */
            ii(0x1012_8f80, 6); mov(memw_a32[ds, 0x101c_5c1f], ax);     /* mov [0x101c5c1f], ax */
            ii(0x1012_8f86, 5); mov(eax, memd_a32[ds, 0x101c_5c1d]);    /* mov eax, [0x101c5c1d] */
            ii(0x1012_8f8b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_8f8e, 5); cmp(eax, 0x226);                        /* cmp eax, 0x226 */
            ii(0x1012_8f93, 2); if(jgd(0x1012_8f9e, 0x9)) goto l_0x1012_8f9e; /* jg 0x10128f9e */
            ii(0x1012_8f95, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1012_8f9c, 2); jmpd(0x1012_8fb7, 0x19); goto l_0x1012_8fb7; /* jmp 0x10128fb7 */
        l_0x1012_8f9e:
            ii(0x1012_8f9e, 5); mov(ecx, 0xb75);                        /* mov ecx, 0xb75 */
            ii(0x1012_8fa3, 5); mov(ebx, StringDefinitions.RemoteCpp);  /* mov ebx, 0x101a830b */
            ii(0x1012_8fa8, 5); mov(edx, StringDefinitions.OutstreamPkthdrPktlengthLessOrEqualMaxdatalen); /* mov edx, 0x101a8316 */
            ii(0x1012_8fad, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_8faf, 5); calld(Definitions.sys_assert, 0x3_cdde); /* call 0x10165d92 */
            ii(0x1012_8fb4, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1012_8fb7:
            ii(0x1012_8fb7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_8fba, 4); mov(dx, memw_a32[ds, eax + 0xc]);       /* mov dx, [eax+0xc] */
            ii(0x1012_8fbe, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8fc1, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
            ii(0x1012_8fc4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_8fc7, 5); calld(Definitions.my_2_get_count, -0x9_dc64); /* call 0x1008b368 */
            ii(0x1012_8fcc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_8fce, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8fd1, 4); mov(memw_a32[ds, eax + 0x4], dx);       /* mov [eax+0x4], dx */
            ii(0x1012_8fd5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_8fd8, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1012_8fdb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8fde, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
            ii(0x1012_8fe1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_8fe4, 4); mov(dx, memw_a32[ds, eax + 0x10]);      /* mov dx, [eax+0x10] */
            ii(0x1012_8fe8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8feb, 4); mov(memw_a32[ds, eax + 0x2], dx);       /* mov [eax+0x2], dx */
            ii(0x1012_8fef, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_8ff2, 3); mov(dl, memb_a32[ds, eax + 0x12]);      /* mov dl, [eax+0x12] */
            ii(0x1012_8ff5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8ff8, 3); mov(memb_a32[ds, eax + 0xc], dl);       /* mov [eax+0xc], dl */
            ii(0x1012_8ffb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_8fff, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_9005, 7); mov(dx, memw_a32[ds, eax + 0x101c_a583]); /* mov dx, [eax+0x101ca583] */
            ii(0x1012_900c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_900f, 4); mov(memw_a32[ds, eax + 0x6], dx);       /* mov [eax+0x6], dx */
            ii(0x1012_9013, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_901a, 2); jmpd(0x1012_9022, 0x6); goto l_0x1012_9022; /* jmp 0x10129022 */
        l_0x1012_901c:
            ii(0x1012_901c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_901f, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1012_9022:
            ii(0x1012_9022, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_9025, 5); calld(Definitions.my_2_get_count, -0x9_dcc2); /* call 0x1008b368 */
            ii(0x1012_902a, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1012_902e, 2); if(jled(0x1012_906c, 0x3c)) goto l_0x1012_906c; /* jle 0x1012906c */
            ii(0x1012_9030, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1012_9034, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_9037, 5); calld(0x1008_b228, -0x9_de14);          /* call 0x1008b228 */
            ii(0x1012_903c, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1012_9040, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1012_9043, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1012_9046, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1012_9049, 4); mov(memw_a32[ds, edx + 0xd], ax);       /* mov [edx+0xd], ax */
            ii(0x1012_904d, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1012_9051, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_9054, 5); calld(0x100e_08bc, -0x4_879d);          /* call 0x100e08bc */
            ii(0x1012_9059, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1012_905d, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1012_9060, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1012_9063, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1012_9066, 4); mov(memw_a32[ds, edx + 0xf], ax);       /* mov [edx+0xf], ax */
            ii(0x1012_906a, 2); jmpd(0x1012_901c, -0x50); goto l_0x1012_901c; /* jmp 0x1012901c */
        l_0x1012_906c:
            ii(0x1012_906c, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_9071, 5); calld(0x1012_5be9, -0x348d);            /* call 0x10125be9 */
            ii(0x1012_9076, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9078, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_907b, 5); calld(0x100e_0244, -0x4_8e3c);          /* call 0x100e0244 */
            ii(0x1012_9080, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9082, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_9085, 5); calld(0x1008_8b04, -0xa_0586);          /* call 0x10088b04 */
            ii(0x1012_908a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_908c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_908d, 1); popd(edi);                              /* pop edi */
            ii(0x1012_908e, 1); popd(esi);                              /* pop esi */
            ii(0x1012_908f, 1); popd(edx);                              /* pop edx */
            ii(0x1012_9090, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_9091, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_9092, 1); retd();                                 /* ret */
        }
    }
}
