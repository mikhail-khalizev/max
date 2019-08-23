using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b50c-ef98f074")]
        public void Method_100a_b50c()
        {
            ii(0x100a_b50c, 5); push(0x30);                             /* push 0x30 */
            ii(0x100a_b511, 5); call(Definitions.sys_check_available_stack_size, 0xb_a83c); /* call 0x10165d52 */
            ii(0x100a_b516, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b517, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b518, 1); push(edx);                              /* push edx */
            ii(0x100a_b519, 1); push(esi);                              /* push esi */
            ii(0x100a_b51a, 1); push(edi);                              /* push edi */
            ii(0x100a_b51b, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b51c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b51e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_b524, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_b527, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b52a, 5); call(0x1015_2700, 0xa_71d1);            /* call 0x10152700 */
            ii(0x100a_b52f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_b531, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_b534, 5); call(0x1008_ae70, -0x2_06c9);           /* call 0x1008ae70 */
            ii(0x100a_b539, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b53c, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100a_b540, 2); if(jnz(0x100a_b551, 0xf)) goto l_0x100a_b551; /* jnz 0x100ab551 */
            ii(0x100a_b542, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b545, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x100a_b548, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_b54d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_b54f, 2); if(jg(0x100a_b553, 0x2)) goto l_0x100a_b553; /* jg 0x100ab553 */
        l_0x100a_b551:
            ii(0x100a_b551, 2); jmp(0x100a_b562, 0xf); goto l_0x100a_b562; /* jmp 0x100ab562 */
        l_0x100a_b553:
            ii(0x100a_b553, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_b555, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_b558, 5); call(0x1008_8bbc, -0x2_29a1);           /* call 0x10088bbc */
            ii(0x100a_b55d, 5); jmp(0x100a_b5ea, 0x88); goto l_0x100a_b5ea; /* jmp 0x100ab5ea */
        l_0x100a_b562:
            ii(0x100a_b562, 2); jmp(0x100a_b56c, 0x8); goto l_0x100a_b56c; /* jmp 0x100ab56c */
        l_0x100a_b564:
            ii(0x100a_b564, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_b567, 5); call(0x1007_6bf8, -0x3_4974);           /* call 0x10076bf8 */
        l_0x100a_b56c:
            ii(0x100a_b56c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_b56e, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_b571, 5); call(0x1013_ad71, 0x8_f7fb);            /* call 0x1013ad71 */
            ii(0x100a_b576, 2); test(al, al);                           /* test al, al */
            ii(0x100a_b578, 2); if(jz(0x100a_b5e0, 0x66)) goto l_0x100a_b5e0; /* jz 0x100ab5e0 */
            ii(0x100a_b57a, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_b57d, 5); call(0x1008_adc4, -0x2_07be);           /* call 0x1008adc4 */
            ii(0x100a_b582, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_b585, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_b588, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_b58b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_b58e, 3); call_abs(memd[ds, edx + 0x20]);         /* call dword [edx+0x20] */
            ii(0x100a_b591, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100a_b593, 2); if(jz(0x100a_b5b0, 0x1b)) goto l_0x100a_b5b0; /* jz 0x100ab5b0 */
            ii(0x100a_b595, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_b598, 5); call(0x1008_adc4, -0x2_07d9);           /* call 0x1008adc4 */
            ii(0x100a_b59d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_b5a0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_b5a3, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_b5a6, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_b5a9, 3); call_abs(memd[ds, edx + 0x20]);         /* call dword [edx+0x20] */
            ii(0x100a_b5ac, 2); cmp(al, 0x10);                          /* cmp al, 0x10 */
            ii(0x100a_b5ae, 2); if(jnz(0x100a_b5de, 0x2e)) goto l_0x100a_b5de; /* jnz 0x100ab5de */
        l_0x100a_b5b0:
            ii(0x100a_b5b0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_b5b2, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_b5b5, 5); call(0x100b_81d0, 0xcc16);              /* call 0x100b81d0 */
            ii(0x100a_b5ba, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_b5bc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b5bf, 5); call(0x1015_2962, 0xa_739e);            /* call 0x10152962 */
            ii(0x100a_b5c4, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_b5c7, 5); call(0x1008_adc4, -0x2_0808);           /* call 0x1008adc4 */
            ii(0x100a_b5cc, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_b5cf, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_b5d2, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x100a_b5d5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_b5d8, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_b5db, 3); call_abs(memd[ds, ebx + 0x54]);         /* call dword [ebx+0x54] */
        l_0x100a_b5de:
            ii(0x100a_b5de, 2); jmp(0x100a_b564, -0x7c); goto l_0x100a_b564; /* jmp 0x100ab564 */
        l_0x100a_b5e0:
            ii(0x100a_b5e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_b5e2, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_b5e5, 5); call(0x1008_8bbc, -0x2_2a2e);           /* call 0x10088bbc */
        l_0x100a_b5ea:
            ii(0x100a_b5ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b5ec, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_b5ed, 1); pop(edi);                               /* pop edi */
            ii(0x100a_b5ee, 1); pop(esi);                               /* pop esi */
            ii(0x100a_b5ef, 1); pop(edx);                               /* pop edx */
            ii(0x100a_b5f0, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b5f1, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b5f2, 1); ret();                                  /* ret */
        }
    }
}
