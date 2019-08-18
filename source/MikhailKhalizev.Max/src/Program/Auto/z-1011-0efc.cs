using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_0efc-859bc294")]
        public void Method_1011_0efc()
        {
            ii(0x1011_0efc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_0f01, 5); calld(Definitions.sys_check_available_stack_size, 0x5_4e4c); /* call 0x10165d52 */
            ii(0x1011_0f06, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_0f07, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_0f08, 1); pushd(edx);                             /* push edx */
            ii(0x1011_0f09, 1); pushd(esi);                             /* push esi */
            ii(0x1011_0f0a, 1); pushd(edi);                             /* push edi */
            ii(0x1011_0f0b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_0f0c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_0f0e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_0f14, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_0f17, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_0f19, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_0f1c, 6); mov(al, memb_a32[ds, edx + 0x142]);     /* mov al, [edx+0x142] */
            ii(0x1011_0f22, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_0f25, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_0f27, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_0f2a, 6); mov(al, memb_a32[ds, edx + 0x140]);     /* mov al, [edx+0x140] */
            ii(0x1011_0f30, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_0f33, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0f36, 7); cmp(memd_a32[ds, eax + 0xc], 0x148);    /* cmp dword [eax+0xc], 0x148 */
            ii(0x1011_0f3d, 2); if(jnzd(0x1011_0f54, 0x15)) goto l_0x1011_0f54; /* jnz 0x10110f54 */
            ii(0x1011_0f3f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_0f43, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1011_0f46, 6); if(jzd(0x1011_102c, 0xe0)) goto l_0x1011_102c; /* jz 0x1011102c */
            ii(0x1011_0f4c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_0f4f, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1011_0f52, 2); jmpd(0x1011_0f5a, 0x6); goto l_0x1011_0f5a; /* jmp 0x10110f5a */
        l_0x1011_0f54:
            ii(0x1011_0f54, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_0f57, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1011_0f5a:
            ii(0x1011_0f5a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_0f5d, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1011_0f61, 2); if(jged(0x1011_0f69, 0x6)) goto l_0x1011_0f69; /* jge 0x10110f69 */
            ii(0x1011_0f63, 4); add(memd_a32[ss, ebp - 0x8], -0xc /* 0xf4 */); /* add dword [ebp-0x8], 0xfffffff4 */
            ii(0x1011_0f67, 2); jmpd(0x1011_0f5a, -0xf); goto l_0x1011_0f5a; /* jmp 0x10110f5a */
        l_0x1011_0f69:
            ii(0x1011_0f69, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_0f6d, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_0f71, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1011_0f74, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_0f76, 2); if(jld(0x1011_0f7e, 0x6)) goto l_0x1011_0f7e; /* jl 0x10110f7e */
            ii(0x1011_0f78, 4); add(memd_a32[ss, ebp - 0x8], 0xc);      /* add dword [ebp-0x8], 0xc */
            ii(0x1011_0f7c, 2); jmpd(0x1011_0f69, -0x15); goto l_0x1011_0f69; /* jmp 0x10110f69 */
        l_0x1011_0f7e:
            ii(0x1011_0f7e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0f81, 6); mov(al, memb_a32[ds, eax + 0x140]);     /* mov al, [eax+0x140] */
            ii(0x1011_0f87, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_0f8c, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_0f90, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_0f92, 2); if(jzd(0x1011_0fb8, 0x24)) goto l_0x1011_0fb8; /* jz 0x10110fb8 */
            ii(0x1011_0f94, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_0f98, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0f9b, 5); calld(0x1011_0e5a, -0x146);             /* call 0x10110e5a */
            ii(0x1011_0fa0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_0fa2, 2); if(jzd(0x1011_0fb8, 0x14)) goto l_0x1011_0fb8; /* jz 0x10110fb8 */
            ii(0x1011_0fa4, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1011_0fa7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_0faa, 6); mov(memb_a32[ds, edx + 0x140], al);     /* mov [edx+0x140], al */
            ii(0x1011_0fb0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0fb3, 5); calld(0x1011_0812, -0x7a6);             /* call 0x10110812 */
        l_0x1011_0fb8:
            ii(0x1011_0fb8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0fbb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_0fbd, 6); mov(dl, memb_a32[ds, eax + 0x140]);     /* mov dl, [eax+0x140] */
            ii(0x1011_0fc3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0fc6, 6); mov(al, memb_a32[ds, eax + 0x141]);     /* mov al, [eax+0x141] */
            ii(0x1011_0fcc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_0fd1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_0fd3, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_0fd7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_0fd9, 2); if(jld(0x1011_0ff7, 0x1c)) goto l_0x1011_0ff7; /* jl 0x10110ff7 */
            ii(0x1011_0fdb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0fde, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_0fe0, 6); mov(dl, memb_a32[ds, eax + 0x140]);     /* mov dl, [eax+0x140] */
            ii(0x1011_0fe6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0fe9, 6); mov(al, memb_a32[ds, eax + 0x141]);     /* mov al, [eax+0x141] */
            ii(0x1011_0fef, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_0ff1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_0ff3, 1); dec(eax);                               /* dec eax */
            ii(0x1011_0ff4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1011_0ff7:
            ii(0x1011_0ff7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0ffa, 6); mov(al, memb_a32[ds, eax + 0x142]);     /* mov al, [eax+0x142] */
            ii(0x1011_1000, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_1005, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_1009, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_100b, 2); if(jzd(0x1011_102c, 0x1f)) goto l_0x1011_102c; /* jz 0x1011102c */
            ii(0x1011_100d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1010, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_1012, 6); mov(bl, memb_a32[ds, eax + 0x140]);     /* mov bl, [eax+0x140] */
            ii(0x1011_1018, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_101c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_101f, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1011_1021, 3); mov(memd_a32[ds, eax + 0xc], edx);      /* mov [eax+0xc], edx */
            ii(0x1011_1024, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1027, 5); calld(0x1011_11dc, 0x1b0);              /* call 0x101111dc */
        l_0x1011_102c:
            ii(0x1011_102c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_102e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_102f, 1); popd(edi);                              /* pop edi */
            ii(0x1011_1030, 1); popd(esi);                              /* pop esi */
            ii(0x1011_1031, 1); popd(edx);                              /* pop edx */
            ii(0x1011_1032, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_1033, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_1034, 1); retd(); return;                         /* ret */
        }
    }
}
