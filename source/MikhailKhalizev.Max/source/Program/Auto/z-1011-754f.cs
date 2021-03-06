using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_754f-a480b0b4")]
        public void Method_1011_754f()
        {
            ii(0x1011_754f, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1011_7554, 5);  call(Definitions.sys_check_available_stack_size, 0x4_e7f9);/* call 0x10165d52 */
            ii(0x1011_7559, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_755a, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_755b, 1);  push(esi);                            /* push esi */
            ii(0x1011_755c, 1);  push(edi);                            /* push edi */
            ii(0x1011_755d, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_755e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_7560, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1011_7566, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_7569, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_756c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_756f, 5);  call(0x1013_aaa8, 0x2_3534);          /* call 0x1013aaa8 */
            ii(0x1011_7574, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_7577, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1011_757a, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_757d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_7580, 3);  add(eax, 0xc);                        /* add eax, 0xc */
            ii(0x1011_7583, 5);  call(Definitions.my_ctor_0x101b_38f8, -0xa_0e98);/* call 0x100766f0 */
            ii(0x1011_7588, 3);  sub(eax, 0xc);                        /* sub eax, 0xc */
            ii(0x1011_758b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_758e, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1011_7591, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_7594, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_7597, 3);  add(eax, 0x10);                       /* add eax, 0x10 */
            ii(0x1011_759a, 5);  call(Definitions.my_ctor_0x101b_4184, -0xa_0aaf);/* call 0x10076af0 */
            ii(0x1011_759f, 3);  sub(eax, 0x10);                       /* sub eax, 0x10 */
            ii(0x1011_75a2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_75a5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_75a8, 7);  mov(memd[ds, eax + 2], 0x101b_6730);  /* mov dword [eax+0x2], 0x101b6730 */
            ii(0x1011_75af, 3);  lea(edx, memd[ss, ebp - 12]);         /* lea edx, [ebp-0xc] */
            ii(0x1011_75b2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_75b5, 5);  call(0x1013_bb7b, 0x2_45c1);          /* call 0x1013bb7b */
            ii(0x1011_75ba, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1011_75be, 5);  call(Definitions.sys_new_arr, 0x4_ea4d);/* call 0x10166010 */
            ii(0x1011_75c3, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_75c6, 3);  mov(memd[ds, edx + 8], eax);          /* mov [edx+0x8], eax */
            ii(0x1011_75c9, 4);  movsx(ebx, memw[ss, ebp - 12]);       /* movsx ebx, word [ebp-0xc] */
            ii(0x1011_75cd, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_75d0, 3);  mov(edx, memd[ds, edx + 8]);          /* mov edx, [edx+0x8] */
            ii(0x1011_75d3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_75d6, 5);  call(0x1013_ba86, 0x2_44ab);          /* call 0x1013ba86 */
            ii(0x1011_75db, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_75de, 5);  call(0x1013_bc8c, 0x2_46a9);          /* call 0x1013bc8c */
            ii(0x1011_75e3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_75e5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_75e8, 3);  add(eax, 0xc);                        /* add eax, 0xc */
            ii(0x1011_75eb, 5);  call(0x1007_6630, -0xa_0fc0);         /* call 0x10076630 */
            ii(0x1011_75f0, 5);  mov(ebx, 4);                          /* mov ebx, 0x4 */
            ii(0x1011_75f5, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_75f8, 3);  add(edx, 0x10);                       /* add edx, 0x10 */
            ii(0x1011_75fb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_75fe, 5);  call(0x1013_ba86, 0x2_4483);          /* call 0x1013ba86 */
            ii(0x1011_7603, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_7606, 3);  add(edx, 0x14);                       /* add edx, 0x14 */
            ii(0x1011_7609, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_760c, 5);  call(0x1013_bb11, 0x2_4500);          /* call 0x1013bb11 */
            ii(0x1011_7611, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1011_7616, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_7619, 3);  add(edx, 6);                          /* add edx, 0x6 */
            ii(0x1011_761c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_761f, 5);  call(0x1013_ba86, 0x2_4462);          /* call 0x1013ba86 */
            ii(0x1011_7624, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_7627, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_762a, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_762d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_762f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_7630, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_7631, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_7632, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_7633, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_7634, 1);  ret();                                /* ret */
        }
    }
}
