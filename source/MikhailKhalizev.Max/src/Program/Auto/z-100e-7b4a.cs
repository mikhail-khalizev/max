using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("213a864c-5e84-4106-b5ed-971a7482636e")]
        public void Method_100e_7b4a()
        {
            ii(0x100e_7b4a, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x100e_7b4f, 5); calld(Definitions.sys_check_available_stack_size, 0x7_e1fe); /* call 0x10165d52 */
            ii(0x100e_7b54, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_7b55, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_7b56, 1); pushd(edx);                             /* push edx */
            ii(0x100e_7b57, 1); pushd(esi);                             /* push esi */
            ii(0x100e_7b58, 1); pushd(edi);                             /* push edi */
            ii(0x100e_7b59, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_7b5a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_7b5c, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100e_7b62, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_7b65, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_7b68, 5); calld(Definitions.my_ctor_0x101b_4184, -0x7_107d); /* call 0x10076af0 */
            ii(0x100e_7b6d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_7b70, 5); calld(0x100e_87ac, 0xc37);              /* call 0x100e87ac */
            ii(0x100e_7b75, 3); lea(edi, ebp - 0x28);                   /* lea edi, [ebp-0x28] */
            ii(0x100e_7b78, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_7b7a, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7b7b, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7b7c, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7b7d, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7b7e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_7b81, 5); calld(0x100e_870c, 0xb86);              /* call 0x100e870c */
            ii(0x100e_7b86, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_7b89, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_7b8c, 5); calld(0x100e_8774, 0xbe3);              /* call 0x100e8774 */
            ii(0x100e_7b91, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_7b94, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_7b97, 5); calld(0x100e_873c, 0xba0);              /* call 0x100e873c */
            ii(0x100e_7b9c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_7b9f, 6); mov(memw_a32[ss, ebp - 0x16], 0);       /* mov word [ebp-0x16], 0x0 */
            ii(0x100e_7ba5, 2); jmpd(0x100e_7bae, 0x7); goto l_0x100e_7bae; /* jmp 0x100e7bae */
        l_0x100e_7ba7:
            ii(0x100e_7ba7, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x100e_7baa, 4); inc(memw_a32[ss, ebp - 0x16]);          /* inc word [ebp-0x16] */
        l_0x100e_7bae:
            ii(0x100e_7bae, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x100e_7bb1, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100e_7bb5, 6); if(jged(0x100e_7c72, 0xb7)) goto l_0x100e_7c72; /* jge 0x100e7c72 */
            ii(0x100e_7bbb, 6); mov(memw_a32[ss, ebp - 0x18], 0);       /* mov word [ebp-0x18], 0x0 */
        l_0x100e_7bc1:
            ii(0x100e_7bc1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_7bc4, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100e_7bc8, 6); if(jged(0x100e_7c6d, 0x9f)) goto l_0x100e_7c6d; /* jge 0x100e7c6d */
        l_0x100e_7bce:
            ii(0x100e_7bce, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_7bd1, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100e_7bd5, 2); if(jged(0x100e_7bf4, 0x1d)) goto l_0x100e_7bf4; /* jge 0x100e7bf4 */
            ii(0x100e_7bd7, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100e_7bdb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_7bde, 3); add(eax, memd_a32[ss, ebp - 0x14]);     /* add eax, [ebp-0x14] */
            ii(0x100e_7be1, 4); movsx(edx, memw_a32[ss, ebp - 0x16]);   /* movsx edx, word [ebp-0x16] */
            ii(0x100e_7be5, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_7be7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_7be9, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_7beb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_7bf0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_7bf2, 2); if(jzd(0x100e_7bf6, 0x2)) goto l_0x100e_7bf6; /* jz 0x100e7bf6 */
        l_0x100e_7bf4:
            ii(0x100e_7bf4, 2); jmpd(0x100e_7bff, 0x9); goto l_0x100e_7bff; /* jmp 0x100e7bff */
        l_0x100e_7bf6:
            ii(0x100e_7bf6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_7bf9, 4); inc(memw_a32[ss, ebp - 0x18]);          /* inc word [ebp-0x18] */
            ii(0x100e_7bfd, 2); jmpd(0x100e_7bce, -0x31); goto l_0x100e_7bce; /* jmp 0x100e7bce */
        l_0x100e_7bff:
            ii(0x100e_7bff, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_7c02, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100e_7c06, 2); if(jged(0x100e_7c68, 0x60)) goto l_0x100e_7c68; /* jge 0x100e7c68 */
            ii(0x100e_7c08, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_7c0b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100e_7c0e:
            ii(0x100e_7c0e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_7c11, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100e_7c15, 2); if(jged(0x100e_7c35, 0x1e)) goto l_0x100e_7c35; /* jge 0x100e7c35 */
            ii(0x100e_7c17, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100e_7c1b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_7c1e, 3); add(eax, memd_a32[ss, ebp - 0x14]);     /* add eax, [ebp-0x14] */
            ii(0x100e_7c21, 4); movsx(edx, memw_a32[ss, ebp - 0x16]);   /* movsx edx, word [ebp-0x16] */
            ii(0x100e_7c25, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_7c27, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_7c29, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_7c2b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_7c30, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_7c33, 2); if(jzd(0x100e_7c37, 0x2)) goto l_0x100e_7c37; /* jz 0x100e7c37 */
        l_0x100e_7c35:
            ii(0x100e_7c35, 2); jmpd(0x100e_7c40, 0x9); goto l_0x100e_7c40; /* jmp 0x100e7c40 */
        l_0x100e_7c37:
            ii(0x100e_7c37, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_7c3a, 4); inc(memw_a32[ss, ebp - 0x18]);          /* inc word [ebp-0x18] */
            ii(0x100e_7c3e, 2); jmpd(0x100e_7c0e, -0x32); goto l_0x100e_7c0e; /* jmp 0x100e7c0e */
        l_0x100e_7c40:
            ii(0x100e_7c40, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_7c43, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_7c46, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_7c49, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x100e_7c4c, 3); add(eax, memd_a32[ss, ebp - 0x24]);     /* add eax, [ebp-0x24] */
            ii(0x100e_7c4f, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_7c52, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_7c55, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_7c58, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_7c5b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_7c5d, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100e_7c62, 1); cwde();                                 /* cwde */
            ii(0x100e_7c63, 5); calld(0x1014_2930, 0x5_acc8);           /* call 0x10142930 */
        l_0x100e_7c68:
            ii(0x100e_7c68, 5); jmpd(0x100e_7bc1, -0xac); goto l_0x100e_7bc1; /* jmp 0x100e7bc1 */
        l_0x100e_7c6d:
            ii(0x100e_7c6d, 5); jmpd(0x100e_7ba7, -0xcb); goto l_0x100e_7ba7; /* jmp 0x100e7ba7 */
        l_0x100e_7c72:
            ii(0x100e_7c72, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_7c74, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_7c75, 1); popd(edi);                              /* pop edi */
            ii(0x100e_7c76, 1); popd(esi);                              /* pop esi */
            ii(0x100e_7c77, 1); popd(edx);                              /* pop edx */
            ii(0x100e_7c78, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_7c79, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_7c7a, 1); retd(); return;                         /* ret */
        }
    }
}
