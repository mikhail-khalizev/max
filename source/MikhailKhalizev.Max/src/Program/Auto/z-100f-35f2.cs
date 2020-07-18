using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_35f2-48ce9b76")]
        public void Method_100f_35f2()
        {
            ii(0x100f_35f2, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100f_35f7, 5);  call(Definitions.sys_check_available_stack_size, 0x7_2756);/* call 0x10165d52 */
            ii(0x100f_35fc, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_35fd, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_35fe, 1);  push(edx);                            /* push edx */
            ii(0x100f_35ff, 1);  push(esi);                            /* push esi */
            ii(0x100f_3600, 1);  push(edi);                            /* push edi */
            ii(0x100f_3601, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_3602, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_3604, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100f_360a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_360d, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_3611, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_3617, 5);  mov(edx, 0x101c_a468);                /* mov edx, 0x101ca468 */
            ii(0x100f_361c, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100f_361e, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100f_3621, 5);  mov(edx, 0x101c_37bc);                /* mov edx, 0x101c37bc */
            ii(0x100f_3626, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_3629, 5);  add(eax, 0xfe);                       /* add eax, 0xfe */
            ii(0x100f_362e, 5);  call(0x1008_ac18, -0x6_8a1b);         /* call 0x1008ac18 */
            ii(0x100f_3633, 7);  mov(dx, memw[ds, 0x101c_38c0]);       /* mov dx, [0x101c38c0] */
            ii(0x100f_363a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_363d, 7);  mov(memw[ds, eax + 258], dx);         /* mov [eax+0x102], dx */
            ii(0x100f_3644, 7);  mov(dx, memw[ds, 0x101c_38e2]);       /* mov dx, [0x101c38e2] */
            ii(0x100f_364b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_364e, 7);  mov(memw[ds, eax + 260], dx);         /* mov [eax+0x104], dx */
            ii(0x100f_3655, 7);  mov(dx, memw[ds, 0x101c_38e4]);       /* mov dx, [0x101c38e4] */
            ii(0x100f_365c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_365f, 7);  mov(memw[ds, eax + 262], dx);         /* mov [eax+0x106], dx */
            ii(0x100f_3666, 6);  mov(dl, memb[ds, 0x101c_3889]);       /* mov dl, [0x101c3889] */
            ii(0x100f_366c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_366f, 6);  mov(memb[ds, eax + 264], dl);         /* mov [eax+0x108], dl */
            ii(0x100f_3675, 6);  mov(dl, memb[ds, 0x101c_388a]);       /* mov dl, [0x101c388a] */
            ii(0x100f_367b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_367e, 6);  mov(memb[ds, eax + 265], dl);         /* mov [eax+0x109], dl */
            ii(0x100f_3684, 6);  mov(dl, memb[ds, 0x101c_37cc]);       /* mov dl, [0x101c37cc] */
            ii(0x100f_368a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_368d, 6);  mov(memb[ds, eax + 266], dl);         /* mov [eax+0x10a], dl */
            ii(0x100f_3693, 6);  mov(dl, memb[ds, 0x101c_37cd]);       /* mov dl, [0x101c37cd] */
            ii(0x100f_3699, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_369c, 6);  mov(memb[ds, eax + 267], dl);         /* mov [eax+0x10b], dl */
            ii(0x100f_36a2, 6);  mov(dl, memb[ds, 0x101c_37ce]);       /* mov dl, [0x101c37ce] */
            ii(0x100f_36a8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_36ab, 6);  mov(memb[ds, eax + 268], dl);         /* mov [eax+0x10c], dl */
            ii(0x100f_36b1, 6);  mov(dl, memb[ds, 0x101c_37cb]);       /* mov dl, [0x101c37cb] */
            ii(0x100f_36b7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_36ba, 6);  mov(memb[ds, eax + 274], dl);         /* mov [eax+0x112], dl */
            ii(0x100f_36c0, 6);  mov(dl, memb[ds, 0x101c_37cf]);       /* mov dl, [0x101c37cf] */
            ii(0x100f_36c6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_36c9, 6);  mov(memb[ds, eax + 269], dl);         /* mov [eax+0x10d], dl */
            ii(0x100f_36cf, 6);  mov(dl, memb[ds, 0x101c_37d0]);       /* mov dl, [0x101c37d0] */
            ii(0x100f_36d5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_36d8, 6);  mov(memb[ds, eax + 270], dl);         /* mov [eax+0x10e], dl */
            ii(0x100f_36de, 5);  mov(al, memb[ds, 0x101c_37d1]);       /* mov al, [0x101c37d1] */
            ii(0x100f_36e3, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_36e6, 6);  mov(memb[ds, edx + 271], al);         /* mov [edx+0x10f], al */
            ii(0x100f_36ec, 5);  mov(al, memb[ds, 0x101c_388d]);       /* mov al, [0x101c388d] */
            ii(0x100f_36f1, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_36f4, 6);  mov(memb[ds, edx + 272], al);         /* mov [edx+0x110], al */
            ii(0x100f_36fa, 5);  mov(al, memb[ds, 0x101c_388e]);       /* mov al, [0x101c388e] */
            ii(0x100f_36ff, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_3702, 6);  mov(memb[ds, edx + 273], al);         /* mov [edx+0x111], al */
            ii(0x100f_3708, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_370a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_370b, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_370c, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_370d, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_370e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_370f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_3710, 1);  ret();                                /* ret */
        }
    }
}
