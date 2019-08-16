using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9aff38ba-1537-4f33-ba64-a158262b59c4")]
        public void Method_1014_9fe6()
        {
            ii(0x1014_9fe6, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1014_9feb, 5); calld(Definitions.sys_check_available_stack_size, 0x1_bd62); /* call 0x10165d52 */
            ii(0x1014_9ff0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_9ff1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_9ff2, 1); pushd(esi);                             /* push esi */
            ii(0x1014_9ff3, 1); pushd(edi);                             /* push edi */
            ii(0x1014_9ff4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_9ff5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_9ff7, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_9ffd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_a000, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_a003, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a006, 3); mov(al, memb_a32[ds, eax + 0x29]);      /* mov al, [eax+0x29] */
            ii(0x1014_a009, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_a00b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_a00e, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_a010, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1014_a013, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1014_a017, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_a019, 6); if(jzd(0x1014_a0e9, 0xca)) goto l_0x1014_a0e9; /* jz 0x1014a0e9 */
            ii(0x1014_a01f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_a021, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1014_a026, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_a029, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a02c, 5); calld(0x1007_6074, -0xd_3fbd);          /* call 0x10076074 */
            ii(0x1014_a031, 2); test(al, al);                           /* test al, al */
            ii(0x1014_a033, 2); if(jnzd(0x1014_a03e, 0x9)) goto l_0x1014_a03e; /* jnz 0x1014a03e */
            ii(0x1014_a035, 7); cmp(memb_a32[ds, 0x101c_3980], 0);      /* cmp byte [0x101c3980], 0x0 */
            ii(0x1014_a03c, 2); if(jzd(0x1014_a044, 0x6)) goto l_0x1014_a044; /* jz 0x1014a044 */
        l_0x1014_a03e:
            ii(0x1014_a03e, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1014_a042, 2); jmpd(0x1014_a048, 0x4); goto l_0x1014_a048; /* jmp 0x1014a048 */
        l_0x1014_a044:
            ii(0x1014_a044, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x1014_a048:
            ii(0x1014_a048, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1014_a04b, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1014_a04e, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1014_a052, 2); if(jzd(0x1014_a05c, 0x8)) goto l_0x1014_a05c; /* jz 0x1014a05c */
            ii(0x1014_a054, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a057, 5); calld(0x1014_9fa8, -0xb4);              /* call 0x10149fa8 */
        l_0x1014_a05c:
            ii(0x1014_a05c, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1014_a05f, 2); and(al, 0x7);                           /* and al, 0x7 */
            ii(0x1014_a061, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_a064, 3); mov(memb_a32[ds, edx + 0x29], al);      /* mov [edx+0x29], al */
            ii(0x1014_a067, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a06a, 7); mov(bx, memw_a32[ds, eax + 0xd5]);      /* mov bx, [eax+0xd5] */
            ii(0x1014_a071, 6); and(ebx, 0xf8);                         /* and ebx, 0xf8 */
            ii(0x1014_a077, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a07a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_a07c, 3); mov(dl, memb_a32[ds, eax + 0x29]);      /* mov dl, [eax+0x29] */
            ii(0x1014_a07f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a082, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1014_a084, 7); mov(memw_a32[ds, eax + 0xd5], bx);      /* mov [eax+0xd5], bx */
            ii(0x1014_a08b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a08e, 4); test(memb_a32[ds, eax + 0x15], 0x2);    /* test byte [eax+0x15], 0x2 */
            ii(0x1014_a092, 2); if(jzd(0x1014_a0d3, 0x3f)) goto l_0x1014_a0d3; /* jz 0x1014a0d3 */
            ii(0x1014_a094, 5); calld(0x1015_5144, 0xb0ab);             /* call 0x10155144 */
            ii(0x1014_a099, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_a09b, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1014_a09d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a0a0, 3); mov(al, memb_a32[ds, eax + 0x2e]);      /* mov al, [eax+0x2e] */
            ii(0x1014_a0a3, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_a0a5, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1014_a0a8, 5); and(eax, 0x7);                          /* and eax, 0x7 */
            ii(0x1014_a0ad, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_a0b0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a0b3, 5); calld(0x1014_e788, 0x46d0);             /* call 0x1014e788 */
            ii(0x1014_a0b8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a0bb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_a0bd, 3); mov(dl, memb_a32[ds, eax + 0x2e]);      /* mov dl, [eax+0x2e] */
            ii(0x1014_a0c0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a0c3, 4); mov(ax, memw_a32[ds, eax + 0x35]);      /* mov ax, [eax+0x35] */
            ii(0x1014_a0c7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_a0c9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_a0cc, 7); mov(memw_a32[ds, edx + 0xd7], ax);      /* mov [edx+0xd7], ax */
        l_0x1014_a0d3:
            ii(0x1014_a0d3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a0d6, 5); calld(0x1014_9cd1, -0x40a);             /* call 0x10149cd1 */
            ii(0x1014_a0db, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1014_a0df, 2); if(jzd(0x1014_a0e9, 0x8)) goto l_0x1014_a0e9; /* jz 0x1014a0e9 */
            ii(0x1014_a0e1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_a0e4, 5); calld(0x1014_9fa8, -0x141);             /* call 0x10149fa8 */
        l_0x1014_a0e9:
            ii(0x1014_a0e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_a0eb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_a0ec, 1); popd(edi);                              /* pop edi */
            ii(0x1014_a0ed, 1); popd(esi);                              /* pop esi */
            ii(0x1014_a0ee, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_a0ef, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_a0f0, 1); retd(); return;                         /* ret */
        }
    }
}