using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_8e05-a69a5a18")]
        public void Method_100d_8e05()
        {
            ii(0x100d_8e05, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100d_8e0a, 5); calld(Definitions.sys_check_available_stack_size, 0x8_cf43); /* call 0x10165d52 */
            ii(0x100d_8e0f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_8e10, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_8e11, 1); pushd(edx);                             /* push edx */
            ii(0x100d_8e12, 1); pushd(esi);                             /* push esi */
            ii(0x100d_8e13, 1); pushd(edi);                             /* push edi */
            ii(0x100d_8e14, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_8e15, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_8e17, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100d_8e1d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_8e20, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100d_8e24, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_8e27, 5); calld(0x100c_a02c, -0xee00);            /* call 0x100ca02c */
            ii(0x100d_8e2c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_8e2f, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100d_8e33, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8e36, 7); cmp(memd_a32[ds, eax + 0x345], 0);      /* cmp dword [eax+0x345], 0x0 */
            ii(0x100d_8e3d, 2); if(jzd(0x100d_8e48, 0x9)) goto l_0x100d_8e48; /* jz 0x100d8e48 */
            ii(0x100d_8e3f, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100d_8e46, 2); jmpd(0x100d_8e61, 0x19); goto l_0x100d_8e61; /* jmp 0x100d8e61 */
        l_0x100d_8e48:
            ii(0x100d_8e48, 5); mov(ecx, 0x3dd);                        /* mov ecx, 0x3dd */
            ii(0x100d_8e4d, 5); mov(ebx, StringDefinitions.CommoCpp18); /* mov ebx, 0x101a180a */
            ii(0x100d_8e52, 5); mov(edx, StringDefinitions.TypeSelectorNotEqual0); /* mov edx, 0x101a1814 */
            ii(0x100d_8e57, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_8e59, 5); calld(Definitions.sys_assert, 0x8_cf34); /* call 0x10165d92 */
            ii(0x100d_8e5e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100d_8e61:
            ii(0x100d_8e61, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_8e68, 2); jmpd(0x100d_8e70, 0x6); goto l_0x100d_8e70; /* jmp 0x100d8e70 */
        l_0x100d_8e6a:
            ii(0x100d_8e6a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_8e6d, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100d_8e70:
            ii(0x100d_8e70, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100d_8e74, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100d_8e77, 2); if(jged(0x100d_8e9c, 0x23)) goto l_0x100d_8e9c; /* jge 0x100d8e9c */
            ii(0x100d_8e79, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100d_8e7d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8e80, 5); calld(0x100d_8d35, -0x150);             /* call 0x100d8d35 */
            ii(0x100d_8e85, 2); test(al, al);                           /* test al, al */
            ii(0x100d_8e87, 2); if(jzd(0x100d_8e9a, 0x11)) goto l_0x100d_8e9a; /* jz 0x100d8e9a */
            ii(0x100d_8e89, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_8e8c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_8e8f, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100d_8e92, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_8e95, 5); calld(0x1008_b2a8, -0x4_dbf2);          /* call 0x1008b2a8 */
        l_0x100d_8e9a:
            ii(0x100d_8e9a, 2); jmpd(0x100d_8e6a, -0x32); goto l_0x100d_8e6a; /* jmp 0x100d8e6a */
        l_0x100d_8e9c:
            ii(0x100d_8e9c, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_8ea3, 2); jmpd(0x100d_8eab, 0x6); goto l_0x100d_8eab; /* jmp 0x100d8eab */
        l_0x100d_8ea5:
            ii(0x100d_8ea5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_8ea8, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100d_8eab:
            ii(0x100d_8eab, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_8eae, 5); calld(Definitions.my_2_get_count, -0x4_db4b); /* call 0x1008b368 */
            ii(0x100d_8eb3, 1); cwde();                                 /* cwde */
            ii(0x100d_8eb4, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100d_8eb8, 1); dec(eax);                               /* dec eax */
            ii(0x100d_8eb9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_8ebb, 6); if(jged(0x100d_8f57, 0x96)) goto l_0x100d_8f57; /* jge 0x100d8f57 */
            ii(0x100d_8ec1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_8ec4, 1); inc(eax);                               /* inc eax */
            ii(0x100d_8ec5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_8ec8, 2); jmpd(0x100d_8ed0, 0x6); goto l_0x100d_8ed0; /* jmp 0x100d8ed0 */
        l_0x100d_8eca:
            ii(0x100d_8eca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_8ecd, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100d_8ed0:
            ii(0x100d_8ed0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_8ed3, 5); calld(Definitions.my_2_get_count, -0x4_db70); /* call 0x1008b368 */
            ii(0x100d_8ed8, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_8edc, 2); if(jled(0x100d_8f52, 0x74)) goto l_0x100d_8f52; /* jle 0x100d8f52 */
            ii(0x100d_8ede, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100d_8ee2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_8ee5, 5); calld(0x1008_b228, -0x4_dcc2);          /* call 0x1008b228 */
            ii(0x100d_8eea, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100d_8eed, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100d_8ef1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_8ef4, 5); calld(0x1008_b228, -0x4_dcd1);          /* call 0x1008b228 */
            ii(0x100d_8ef9, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100d_8efc, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100d_8efe, 5); calld(0x100d_8b00, -0x403);             /* call 0x100d8b00 */
            ii(0x100d_8f03, 2); test(al, al);                           /* test al, al */
            ii(0x100d_8f05, 2); if(jzd(0x100d_8f4d, 0x46)) goto l_0x100d_8f4d; /* jz 0x100d8f4d */
            ii(0x100d_8f07, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100d_8f0b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_8f0e, 5); calld(0x1008_b228, -0x4_dceb);          /* call 0x1008b228 */
            ii(0x100d_8f13, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100d_8f16, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100d_8f19, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100d_8f1d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_8f20, 5); calld(0x1008_b228, -0x4_dcfd);          /* call 0x1008b228 */
            ii(0x100d_8f25, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_8f27, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100d_8f2b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_8f2e, 5); calld(0x1008_b228, -0x4_dd0b);          /* call 0x1008b228 */
            ii(0x100d_8f33, 3); mov(dx, memw_a32[ds, ebx]);             /* mov dx, [ebx] */
            ii(0x100d_8f36, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
            ii(0x100d_8f39, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100d_8f3d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_8f40, 5); calld(0x1008_b228, -0x4_dd1d);          /* call 0x1008b228 */
            ii(0x100d_8f45, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_8f47, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_8f4a, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
        l_0x100d_8f4d:
            ii(0x100d_8f4d, 5); jmpd(0x100d_8eca, -0x88); goto l_0x100d_8eca; /* jmp 0x100d8eca */
        l_0x100d_8f52:
            ii(0x100d_8f52, 5); jmpd(0x100d_8ea5, -0xb2); goto l_0x100d_8ea5; /* jmp 0x100d8ea5 */
        l_0x100d_8f57:
            ii(0x100d_8f57, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100d_8f5a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8f5d, 6); mov(eax, memd_a32[ds, eax + 0x345]);    /* mov eax, [eax+0x345] */
            ii(0x100d_8f63, 5); calld(0x100d_0264, -0x8d04);            /* call 0x100d0264 */
            ii(0x100d_8f68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8f6a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_8f6d, 5); calld(0x1008_8b04, -0x5_046e);          /* call 0x10088b04 */
            ii(0x100d_8f72, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_8f74, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_8f75, 1); popd(edi);                              /* pop edi */
            ii(0x100d_8f76, 1); popd(esi);                              /* pop esi */
            ii(0x100d_8f77, 1); popd(edx);                              /* pop edx */
            ii(0x100d_8f78, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_8f79, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_8f7a, 1); retd();                                 /* ret */
        }
    }
}
