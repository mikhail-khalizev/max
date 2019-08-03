using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3a3e15cd-d59b-4994-8176-aecaf0cb6ab9")]
        public void Method_100f_e5cd()
        {
            ii(0x100f_e5cd, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100f_e5d2, 5); calld(Definitions.sys_check_available_stack_size, 0x6777b); /* call 0x10165d52 */
            ii(0x100f_e5d7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_e5d8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_e5d9, 1); pushd(edx);                             /* push edx */
            ii(0x100f_e5da, 1); pushd(esi);                             /* push esi */
            ii(0x100f_e5db, 1); pushd(edi);                             /* push edi */
            ii(0x100f_e5dc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_e5dd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_e5df, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_e5e5, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_e5ec, 2); if(jnzd(0x100f_e5fa, 0xc)) goto l_0x100f_e5fa; /* jnz 0x100fe5fa */
            ii(0x100f_e5ee, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x100f_e5f5, 5); jmpd(0x100f_e744, 0x14a); goto l_0x100f_e744; /* jmp 0x100fe744 */
        l_0x100f_e5fa:
            ii(0x100f_e5fa, 7); mov(memd_a32[ss, ebp - 0x4], 0xffff_ffff); /* mov dword [ebp-0x4], 0xffffffff */
            ii(0x100f_e601, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_e608, 2); jmpd(0x100f_e610, 0x6); goto l_0x100f_e610; /* jmp 0x100fe610 */
        l_0x100f_e60a:
            ii(0x100f_e60a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_e60d, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100f_e610:
            ii(0x100f_e610, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_e614, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x100f_e617, 2); if(jged(0x100f_e630, 0x17)) goto l_0x100f_e630; /* jge 0x100fe630 */
            ii(0x100f_e619, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_e61d, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_e621, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x100f_e626, 5); calld(0x100f_e3b7, -0x274);             /* call 0x100fe3b7 */
            ii(0x100f_e62b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e62e, 2); jmpd(0x100f_e60a, -0x26); goto l_0x100f_e60a; /* jmp 0x100fe60a */
        l_0x100f_e630:
            ii(0x100f_e630, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_e637, 2); jmpd(0x100f_e63f, 0x6); goto l_0x100f_e63f; /* jmp 0x100fe63f */
        l_0x100f_e639:
            ii(0x100f_e639, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_e63c, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100f_e63f:
            ii(0x100f_e63f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_e643, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x100f_e646, 2); if(jged(0x100f_e65f, 0x17)) goto l_0x100f_e65f; /* jge 0x100fe65f */
            ii(0x100f_e648, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_e64c, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_e650, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100f_e655, 5); calld(0x100f_e3b7, -0x2a3);             /* call 0x100fe3b7 */
            ii(0x100f_e65a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e65d, 2); jmpd(0x100f_e639, -0x26); goto l_0x100f_e639; /* jmp 0x100fe639 */
        l_0x100f_e65f:
            ii(0x100f_e65f, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_e666, 2); jmpd(0x100f_e66e, 0x6); goto l_0x100f_e66e; /* jmp 0x100fe66e */
        l_0x100f_e668:
            ii(0x100f_e668, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_e66b, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100f_e66e:
            ii(0x100f_e66e, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_e672, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x100f_e675, 2); if(jged(0x100f_e68e, 0x17)) goto l_0x100f_e68e; /* jge 0x100fe68e */
            ii(0x100f_e677, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_e67b, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_e67f, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100f_e684, 5); calld(0x100f_e3b7, -0x2d2);             /* call 0x100fe3b7 */
            ii(0x100f_e689, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e68c, 2); jmpd(0x100f_e668, -0x26); goto l_0x100f_e668; /* jmp 0x100fe668 */
        l_0x100f_e68e:
            ii(0x100f_e68e, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_e695, 2); jmpd(0x100f_e69d, 0x6); goto l_0x100f_e69d; /* jmp 0x100fe69d */
        l_0x100f_e697:
            ii(0x100f_e697, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_e69a, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100f_e69d:
            ii(0x100f_e69d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_e6a1, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x100f_e6a4, 2); if(jged(0x100f_e6bd, 0x17)) goto l_0x100f_e6bd; /* jge 0x100fe6bd */
            ii(0x100f_e6a6, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_e6aa, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_e6ae, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100f_e6b3, 5); calld(0x100f_e3b7, -0x301);             /* call 0x100fe3b7 */
            ii(0x100f_e6b8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e6bb, 2); jmpd(0x100f_e697, -0x26); goto l_0x100f_e697; /* jmp 0x100fe697 */
        l_0x100f_e6bd:
            ii(0x100f_e6bd, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e6c1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e6c3, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_e6c8, 1); cwde();                                 /* cwde */
            ii(0x100f_e6c9, 5); calld(0x1012_b3dd, 0x2cd0f);            /* call 0x1012b3dd */
            ii(0x100f_e6ce, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e6d0, 2); if(jzd(0x100f_e6db, 0x9)) goto l_0x100f_e6db; /* jz 0x100fe6db */
            ii(0x100f_e6d2, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x100f_e6d9, 2); jmpd(0x100f_e744, 0x69); goto l_0x100f_e744; /* jmp 0x100fe744 */
        l_0x100f_e6db:
            ii(0x100f_e6db, 5); calld(0x1011_74f2, 0x18e12);            /* call 0x101174f2 */
            ii(0x100f_e6e0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e6e2, 2); if(jzd(0x100f_e731, 0x4d)) goto l_0x100f_e731; /* jz 0x100fe731 */
            ii(0x100f_e6e4, 5); calld(0x100e_f348, -0xf3a1);            /* call 0x100ef348 */
            ii(0x100f_e6e9, 1); cwde();                                 /* cwde */
            ii(0x100f_e6ea, 5); calld(0x100f_3499, -0xb256);            /* call 0x100f3499 */
            ii(0x100f_e6ef, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_e6f2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_e6f4, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_e6f7, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100f_e6fc, 5); calld(0x100f_39b4, -0xad4d);            /* call 0x100f39b4 */
            ii(0x100f_e701, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e703, 2); if(jnzd(0x100f_e72f, 0x2a)) goto l_0x100f_e72f; /* jnz 0x100fe72f */
            ii(0x100f_e705, 7); mov(memb_a32[ds, 0x101c_391e], 0x3);    /* mov byte [0x101c391e], 0x3 */
            ii(0x100f_e70c, 5); calld(0x100c_aa00, -0x33d11);           /* call 0x100caa00 */
            ii(0x100f_e711, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_e716, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e717, 5); calld(0x100c_aa20, -0x33cfc);           /* call 0x100caa20 */
            ii(0x100f_e71c, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_e71e, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_e723, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e725, 5); mov(eax, 0x101a_2a40);                  /* mov eax, 0x101a2a40 */ /* "Auto-save file not found. Unable to continue with this game." */
            ii(0x100f_e72a, 5); calld(0x1011_5d23, 0x175f4);            /* call 0x10115d23 */
        l_0x100f_e72f:
            ii(0x100f_e72f, 2); jmpd(0x100f_e738, 0x7); goto l_0x100f_e738; /* jmp 0x100fe738 */
        l_0x100f_e731:
            ii(0x100f_e731, 7); mov(memb_a32[ds, 0x101c_391e], 0x3);    /* mov byte [0x101c391e], 0x3 */
        l_0x100f_e738:
            ii(0x100f_e738, 5); calld(0x100e_a903, -0x13e3a);           /* call 0x100ea903 */
            ii(0x100f_e73d, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x100f_e744:
            ii(0x100f_e744, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_e747, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_e749, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_e74a, 1); popd(edi);                              /* pop edi */
            ii(0x100f_e74b, 1); popd(esi);                              /* pop esi */
            ii(0x100f_e74c, 1); popd(edx);                              /* pop edx */
            ii(0x100f_e74d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_e74e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_e74f, 1); retd(); return;                         /* ret */
        }
    }
}
