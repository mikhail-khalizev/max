using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d4e0-750923e5")]
        public void Method_100c_d4e0()
        {
            ii(0x100c_d4e0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_d4e5, 5); calld(Definitions.sys_check_available_stack_size, 0x9_8868); /* call 0x10165d52 */
            ii(0x100c_d4ea, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_d4eb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_d4ec, 1); pushd(edx);                             /* push edx */
            ii(0x100c_d4ed, 1); pushd(esi);                             /* push esi */
            ii(0x100c_d4ee, 1); pushd(edi);                             /* push edi */
            ii(0x100c_d4ef, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_d4f0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d4f2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_d4f8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_d4fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d4fe, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d501, 5); calld(0x1007_65d0, -0x5_6f36);          /* call 0x100765d0 */
            ii(0x100c_d506, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_d508, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d50b, 3); mov(ebx, memd_a32[ds, eax + 0x7]);      /* mov ebx, [eax+0x7] */
            ii(0x100c_d50e, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_d511, 6); imul(ebx, ebx, 0xc5);                   /* imul ebx, ebx, 0xc5 */
            ii(0x100c_d517, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100c_d51c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_d51e, 5); calld(0x100c_343a, -0xa0e9);            /* call 0x100c343a */
            ii(0x100c_d523, 2); test(al, al);                           /* test al, al */
            ii(0x100c_d525, 2); if(jzd(0x100c_d52d, 0x6)) goto l_0x100c_d52d; /* jz 0x100cd52d */
            ii(0x100c_d527, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100c_d52b, 2); jmpd(0x100c_d567, 0x3a); goto l_0x100c_d567; /* jmp 0x100cd567 */
        l_0x100c_d52d:
            ii(0x100c_d52d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d530, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d533, 5); calld(0x1007_6574, -0x5_6fc4);          /* call 0x10076574 */
            ii(0x100c_d538, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_d53a, 3); mov(dl, memb_a32[ds, eax + 0x54]);      /* mov dl, [eax+0x54] */
            ii(0x100c_d53d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d540, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d543, 5); calld(0x1007_6574, -0x5_6fd4);          /* call 0x10076574 */
            ii(0x100c_d548, 5); calld(0x1007_623c, -0x5_7311);          /* call 0x1007623c */
            ii(0x100c_d54d, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100c_d550, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_d553, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_d555, 2); if(jld(0x100c_d55d, 0x6)) goto l_0x100c_d55d; /* jl 0x100cd55d */
            ii(0x100c_d557, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_d55b, 2); jmpd(0x100c_d561, 0x4); goto l_0x100c_d561; /* jmp 0x100cd561 */
        l_0x100c_d55d:
            ii(0x100c_d55d, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x100c_d561:
            ii(0x100c_d561, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100c_d564, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x100c_d567:
            ii(0x100c_d567, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100c_d56a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d56c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_d56d, 1); popd(edi);                              /* pop edi */
            ii(0x100c_d56e, 1); popd(esi);                              /* pop esi */
            ii(0x100c_d56f, 1); popd(edx);                              /* pop edx */
            ii(0x100c_d570, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_d571, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_d572, 1); retd(); return;                         /* ret */
        }
    }
}
