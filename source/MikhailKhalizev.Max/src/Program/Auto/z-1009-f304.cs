using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_f304-ed507f2d")]
        public void Method_1009_f304()
        {
            ii(0x1009_f304, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1009_f309, 5);  call(Definitions.sys_check_available_stack_size, 0xc_6a44);/* call 0x10165d52 */
            ii(0x1009_f30e, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_f30f, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_f310, 1);  push(esi);                            /* push esi */
            ii(0x1009_f311, 1);  push(edi);                            /* push edi */
            ii(0x1009_f312, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_f313, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_f315, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1009_f31b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_f31e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_f321, 5);  mov(ecx, 0x2200);                     /* mov ecx, 0x2200 */
            ii(0x1009_f326, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_f328, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_f32b, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1009_f32e, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1009_f330, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1009_f333, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f336, 5);  call(0x100a_26d1, 0x3396);            /* call 0x100a26d1 */
            ii(0x1009_f33b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_f33e, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1009_f341, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_f344, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f347, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_f34a, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_885f);/* call 0x10076af0 */
            ii(0x1009_f34f, 3);  sub(eax, 0x13);                       /* sub eax, 0x13 */
            ii(0x1009_f352, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_f355, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f358, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_f35b, 5);  call(Definitions.my_ctor_0x101b_38f8, -0x2_8c70);/* call 0x100766f0 */
            ii(0x1009_f360, 3);  sub(eax, 0x17);                       /* sub eax, 0x17 */
            ii(0x1009_f363, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_f366, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1009_f369, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_f36c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f36f, 3);  add(eax, 0x1f);                       /* add eax, 0x1f */
            ii(0x1009_f372, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_8887);/* call 0x10076af0 */
            ii(0x1009_f377, 3);  sub(eax, 0x1f);                       /* sub eax, 0x1f */
            ii(0x1009_f37a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_f37d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f380, 3);  add(eax, 0x23);                       /* add eax, 0x23 */
            ii(0x1009_f383, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_8898);/* call 0x10076af0 */
            ii(0x1009_f388, 3);  sub(eax, 0x23);                       /* sub eax, 0x23 */
            ii(0x1009_f38b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_f38e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f391, 7);  mov(memd[ds, eax + 2], 0x101b_48d8);  /* mov dword [eax+0x2], 0x101b48d8 */
            ii(0x1009_f398, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_f39b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f39e, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_f3a1, 5);  call(0x1007_6630, -0x2_8d76);         /* call 0x10076630 */
            ii(0x1009_f3a6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_f3a9, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1009_f3ad, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_f3b0, 4);  mov(memw[ds, edx + 19], ax);          /* mov [edx+0x13], ax */
            ii(0x1009_f3b4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_f3b7, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x1009_f3bb, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_f3be, 4);  mov(memw[ds, edx + 21], ax);          /* mov [edx+0x15], ax */
            ii(0x1009_f3c2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f3c5, 6);  mov(memw[ds, eax + 27], 0);           /* mov word [eax+0x1b], 0x0 */
            ii(0x1009_f3cb, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1009_f3d0, 5);  call(0x1007_6338, -0x2_909d);         /* call 0x10076338 */
            ii(0x1009_f3d5, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_f3d7, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_f3da, 5);  call(0x1007_64b8, -0x2_8f27);         /* call 0x100764b8 */
            ii(0x1009_f3df, 2);  jmp(0x1009_f3e9, 8); goto l_0x1009_f3e9;/* jmp 0x1009f3e9 */
        l_0x1009_f3e1:
            ii(0x1009_f3e1, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_f3e4, 5);  call(0x1007_6bf8, -0x2_87f1);         /* call 0x10076bf8 */
        l_0x1009_f3e9:
            ii(0x1009_f3e9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_f3eb, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_f3ee, 5);  call(0x1013_ad71, 0x9_b97e);          /* call 0x1013ad71 */
            ii(0x1009_f3f3, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_f3f5, 2);  if(jz(0x1009_f456, 0x5f)) goto l_0x1009_f456;/* jz 0x1009f456 */
            ii(0x1009_f3f7, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_f3fa, 5);  call(0x1007_63a0, -0x2_905f);         /* call 0x100763a0 */
            ii(0x1009_f3ff, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_f401, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1009_f404, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f407, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_f40a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_f40d, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_f40f, 2);  if(jnz(0x1009_f420, 0xf)) goto l_0x1009_f420;/* jnz 0x1009f420 */
            ii(0x1009_f411, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_f414, 5);  call(0x1007_63a0, -0x2_9079);         /* call 0x100763a0 */
            ii(0x1009_f419, 5);  cmp(memw[ds, eax + 8], 0x28);         /* cmp word [eax+0x8], 0x28 */
            ii(0x1009_f41e, 2);  if(jz(0x1009_f422, 2)) goto l_0x1009_f422;/* jz 0x1009f422 */
        l_0x1009_f420:
            ii(0x1009_f420, 2);  jmp(0x1009_f454, 0x32); goto l_0x1009_f454;/* jmp 0x1009f454 */
        l_0x1009_f422:
            ii(0x1009_f422, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_f425, 5);  call(0x1007_63a0, -0x2_908a);         /* call 0x100763a0 */
            ii(0x1009_f42a, 4);  mov(dx, memw[ds, eax + 26]);          /* mov dx, [eax+0x1a] */
            ii(0x1009_f42e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f431, 4);  mov(memw[ds, eax + 19], dx);          /* mov [eax+0x13], dx */
            ii(0x1009_f435, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_f438, 5);  call(0x1007_63a0, -0x2_909d);         /* call 0x100763a0 */
            ii(0x1009_f43d, 4);  mov(dx, memw[ds, eax + 28]);          /* mov dx, [eax+0x1c] */
            ii(0x1009_f441, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f444, 4);  mov(memw[ds, eax + 21], dx);          /* mov [eax+0x15], dx */
            ii(0x1009_f448, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_f44a, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_f44d, 5);  call(0x1007_5f6c, -0x2_94e6);         /* call 0x10075f6c */
            ii(0x1009_f452, 2);  jmp(0x1009_f460, 0xc); goto l_0x1009_f460;/* jmp 0x1009f460 */
        l_0x1009_f454:
            ii(0x1009_f454, 2);  jmp(0x1009_f3e1, -0x75); goto l_0x1009_f3e1;/* jmp 0x1009f3e1 */
        l_0x1009_f456:
            ii(0x1009_f456, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_f458, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_f45b, 5);  call(0x1007_5f6c, -0x2_94f4);         /* call 0x10075f6c */
        l_0x1009_f460:
            ii(0x1009_f460, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f463, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_f466, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_f469, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_f46b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_f46c, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_f46d, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_f46e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_f46f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_f470, 1);  ret();                                /* ret */
        }
    }
}
