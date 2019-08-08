using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3ecf190e-6fc9-4c29-a049-961e61835a1b")]
        public void Method_1012_93c3()
        {
            ii(0x1012_93c3, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_93c8, 5); calld(Definitions.sys_check_available_stack_size, 0x3_c985); /* call 0x10165d52 */
            ii(0x1012_93cd, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_93ce, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_93cf, 1); pushd(edx);                             /* push edx */
            ii(0x1012_93d0, 1); pushd(esi);                             /* push esi */
            ii(0x1012_93d1, 1); pushd(edi);                             /* push edi */
            ii(0x1012_93d2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_93d3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_93d5, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_93db, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x11);   /* mov byte [0x101c5c1c], 0x11 */
            ii(0x1012_93e2, 9); mov(memw_a32[ds, 0x101c_5c1d], 0);      /* mov word [0x101c5c1d], 0x0 */
            ii(0x1012_93eb, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x44);   /* mov word [0x101c5c1f], 0x44 */
            ii(0x1012_93f4, 7); mov(memd_a32[ss, ebp - 0x4], 0x101c_5c21); /* mov dword [ebp-0x4], 0x101c5c21 */
            ii(0x1012_93fb, 6); mov(dl, memb_a32[ds, 0x101c_391e]);     /* mov dl, [0x101c391e] */
            ii(0x1012_9401, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_9404, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x1012_9406, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x1012_940b, 5); calld(0x1007_5fdc, -0xb_3434);          /* call 0x10075fdc */
            ii(0x1012_9410, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_9412, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_9415, 3); mov(memb_a32[ds, eax + 0x1], dl);       /* mov [eax+0x1], dl */
            ii(0x1012_9418, 5); mov(eax, 0x3d);                         /* mov eax, 0x3d */
            ii(0x1012_941d, 5); calld(0x1007_5fdc, -0xb_3446);          /* call 0x10075fdc */
            ii(0x1012_9422, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_9424, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_9427, 3); mov(memb_a32[ds, eax + 0x2], dl);       /* mov [eax+0x2], dl */
            ii(0x1012_942a, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1012_942f, 5); calld(0x1007_5fdc, -0xb_3458);          /* call 0x10075fdc */
            ii(0x1012_9434, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9437, 3); mov(memb_a32[ds, edx + 0x3], al);       /* mov [edx+0x3], al */
            ii(0x1012_943a, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1012_943f, 5); calld(0x1007_5fdc, -0xb_3468);          /* call 0x10075fdc */
            ii(0x1012_9444, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9447, 3); mov(memb_a32[ds, edx + 0x4], al);       /* mov [edx+0x4], al */
            ii(0x1012_944a, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1012_944f, 5); calld(0x1007_5fdc, -0xb_3478);          /* call 0x10075fdc */
            ii(0x1012_9454, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9457, 3); mov(memb_a32[ds, edx + 0x5], al);       /* mov [edx+0x5], al */
            ii(0x1012_945a, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_945f, 5); calld(0x1007_5fdc, -0xb_3488);          /* call 0x10075fdc */
            ii(0x1012_9464, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_9466, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_9469, 3); mov(memb_a32[ds, eax + 0x6], dl);       /* mov [eax+0x6], dl */
            ii(0x1012_946c, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_9471, 5); calld(0x1007_5fdc, -0xb_349a);          /* call 0x10075fdc */
            ii(0x1012_9476, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9479, 3); mov(memb_a32[ds, edx + 0x7], al);       /* mov [edx+0x7], al */
            ii(0x1012_947c, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1012_9481, 5); calld(0x1007_5fdc, -0xb_34aa);          /* call 0x10075fdc */
            ii(0x1012_9486, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9489, 4); mov(memw_a32[ds, edx + 0xb], ax);       /* mov [edx+0xb], ax */
            ii(0x1012_948d, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1012_9492, 5); calld(0x1007_5fdc, -0xb_34bb);          /* call 0x10075fdc */
            ii(0x1012_9497, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_949a, 4); mov(memw_a32[ds, edx + 0xd], ax);       /* mov [edx+0xd], ax */
            ii(0x1012_949e, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x1012_94a3, 5); calld(0x1007_5fdc, -0xb_34cc);          /* call 0x10075fdc */
            ii(0x1012_94a8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_94ab, 4); mov(memw_a32[ds, edx + 0xf], ax);       /* mov [edx+0xf], ax */
            ii(0x1012_94af, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
            ii(0x1012_94b4, 5); calld(0x1007_5fdc, -0xb_34dd);          /* call 0x10075fdc */
            ii(0x1012_94b9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_94bc, 3); mov(memb_a32[ds, edx + 0x8], al);       /* mov [edx+0x8], al */
            ii(0x1012_94bf, 5); mov(eax, 0x3c);                         /* mov eax, 0x3c */
            ii(0x1012_94c4, 5); calld(0x1007_5fdc, -0xb_34ed);          /* call 0x10075fdc */
            ii(0x1012_94c9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_94cc, 4); mov(memw_a32[ds, edx + 0x11], ax);      /* mov [edx+0x11], ax */
            ii(0x1012_94d0, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1012_94d5, 5); calld(0x1007_5fdc, -0xb_34fe);          /* call 0x10075fdc */
            ii(0x1012_94da, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_94dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_94df, 3); mov(memb_a32[ds, eax + 0x9], dl);       /* mov [eax+0x9], dl */
            ii(0x1012_94e2, 5); mov(eax, 0x55);                         /* mov eax, 0x55 */
            ii(0x1012_94e7, 5); calld(0x1007_5fdc, -0xb_3510);          /* call 0x10075fdc */
            ii(0x1012_94ec, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_94ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_94f1, 3); mov(memb_a32[ds, eax + 0xa], dl);       /* mov [eax+0xa], dl */
            ii(0x1012_94f4, 6); mov(dl, memb_a32[ds, 0x101c_3966]);     /* mov dl, [0x101c3966] */
            ii(0x1012_94fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_94fd, 3); mov(memb_a32[ds, eax + 0x13], dl);      /* mov [eax+0x13], dl */
            ii(0x1012_9500, 7); mov(dx, memw_a32[ds, 0x101c_3968]);     /* mov dx, [0x101c3968] */
            ii(0x1012_9507, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_950a, 4); mov(memw_a32[ds, eax + 0x14], dx);      /* mov [eax+0x14], dx */
            ii(0x1012_950e, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1012_9513, 5); calld(0x1007_5fdc, -0xb_353c);          /* call 0x10075fdc */
            ii(0x1012_9518, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_951b, 4); mov(memw_a32[ds, edx + 0x16], ax);      /* mov [edx+0x16], ax */
            ii(0x1012_951f, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1012_9524, 5); calld(0x1007_5fdc, -0xb_354d);          /* call 0x10075fdc */
            ii(0x1012_9529, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_952c, 4); mov(memw_a32[ds, edx + 0x18], ax);      /* mov [edx+0x18], ax */
            ii(0x1012_9530, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x1012_9535, 5); calld(0x1007_5fdc, -0xb_355e);          /* call 0x10075fdc */
            ii(0x1012_953a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_953d, 4); mov(memw_a32[ds, edx + 0x1a], ax);      /* mov [edx+0x1a], ax */
            ii(0x1012_9541, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1012_9546, 5); calld(0x1007_5fdc, -0xb_356f);          /* call 0x10075fdc */
            ii(0x1012_954b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_954e, 4); mov(memw_a32[ds, edx + 0x1c], ax);      /* mov [edx+0x1c], ax */
            ii(0x1012_9552, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1012_9557, 5); calld(0x1007_5fdc, -0xb_3580);          /* call 0x10075fdc */
            ii(0x1012_955c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_955f, 4); mov(memw_a32[ds, edx + 0x1e], ax);      /* mov [edx+0x1e], ax */
            ii(0x1012_9563, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x1012_9568, 5); calld(0x1007_5fdc, -0xb_3591);          /* call 0x10075fdc */
            ii(0x1012_956d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9570, 4); mov(memw_a32[ds, edx + 0x20], ax);      /* mov [edx+0x20], ax */
            ii(0x1012_9574, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1012_9579, 5); calld(0x1007_5fdc, -0xb_35a2);          /* call 0x10075fdc */
            ii(0x1012_957e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9581, 4); mov(memw_a32[ds, edx + 0x22], ax);      /* mov [edx+0x22], ax */
            ii(0x1012_9585, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1012_958a, 5); calld(0x1007_5fdc, -0xb_35b3);          /* call 0x10075fdc */
            ii(0x1012_958f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9592, 4); mov(memw_a32[ds, edx + 0x24], ax);      /* mov [edx+0x24], ax */
            ii(0x1012_9596, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1012_959b, 5); calld(0x1007_5fdc, -0xb_35c4);          /* call 0x10075fdc */
            ii(0x1012_95a0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_95a3, 4); mov(memw_a32[ds, edx + 0x26], ax);      /* mov [edx+0x26], ax */
            ii(0x1012_95a7, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1012_95ac, 5); calld(0x1007_5fdc, -0xb_35d5);          /* call 0x10075fdc */
            ii(0x1012_95b1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_95b4, 4); mov(memw_a32[ds, edx + 0x28], ax);      /* mov [edx+0x28], ax */
            ii(0x1012_95b8, 5); mov(eax, 0x13);                         /* mov eax, 0x13 */
            ii(0x1012_95bd, 5); calld(0x1007_5fdc, -0xb_35e6);          /* call 0x10075fdc */
            ii(0x1012_95c2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_95c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_95c7, 4); mov(memw_a32[ds, eax + 0x2a], dx);      /* mov [eax+0x2a], dx */
            ii(0x1012_95cb, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_95d0, 5); calld(0x1007_5fdc, -0xb_35f9);          /* call 0x10075fdc */
            ii(0x1012_95d5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_95d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_95da, 4); mov(memw_a32[ds, eax + 0x2c], dx);      /* mov [eax+0x2c], dx */
            ii(0x1012_95de, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1012_95e3, 5); calld(0x1007_5fdc, -0xb_360c);          /* call 0x10075fdc */
            ii(0x1012_95e8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_95ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_95ed, 4); mov(memw_a32[ds, eax + 0x2e], dx);      /* mov [eax+0x2e], dx */
            ii(0x1012_95f1, 5); mov(eax, 0x16);                         /* mov eax, 0x16 */
            ii(0x1012_95f6, 5); calld(0x1007_5fdc, -0xb_361f);          /* call 0x10075fdc */
            ii(0x1012_95fb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_95fe, 4); mov(memw_a32[ds, edx + 0x30], ax);      /* mov [edx+0x30], ax */
            ii(0x1012_9602, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x1012_9607, 5); calld(0x1007_5fdc, -0xb_3630);          /* call 0x10075fdc */
            ii(0x1012_960c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_960f, 4); mov(memw_a32[ds, edx + 0x32], ax);      /* mov [edx+0x32], ax */
            ii(0x1012_9613, 5); mov(eax, 0x18);                         /* mov eax, 0x18 */
            ii(0x1012_9618, 5); calld(0x1007_5fdc, -0xb_3641);          /* call 0x10075fdc */
            ii(0x1012_961d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9620, 4); mov(memw_a32[ds, edx + 0x34], ax);      /* mov [edx+0x34], ax */
            ii(0x1012_9624, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x1012_9629, 5); calld(0x1007_5fdc, -0xb_3652);          /* call 0x10075fdc */
            ii(0x1012_962e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9631, 4); mov(memw_a32[ds, edx + 0x36], ax);      /* mov [edx+0x36], ax */
            ii(0x1012_9635, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1012_963a, 5); calld(0x1007_5fdc, -0xb_3663);          /* call 0x10075fdc */
            ii(0x1012_963f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9642, 4); mov(memw_a32[ds, edx + 0x38], ax);      /* mov [edx+0x38], ax */
            ii(0x1012_9646, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1012_964b, 5); calld(0x1007_5fdc, -0xb_3674);          /* call 0x10075fdc */
            ii(0x1012_9650, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9653, 4); mov(memw_a32[ds, edx + 0x3a], ax);      /* mov [edx+0x3a], ax */
            ii(0x1012_9657, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x1012_965c, 5); calld(0x1007_5fdc, -0xb_3685);          /* call 0x10075fdc */
            ii(0x1012_9661, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9664, 4); mov(memw_a32[ds, edx + 0x3c], ax);      /* mov [edx+0x3c], ax */
            ii(0x1012_9668, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1012_966d, 5); calld(0x1007_5fdc, -0xb_3696);          /* call 0x10075fdc */
            ii(0x1012_9672, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9675, 4); mov(memw_a32[ds, edx + 0x3e], ax);      /* mov [edx+0x3e], ax */
            ii(0x1012_9679, 5); mov(eax, 0x2b);                         /* mov eax, 0x2b */
            ii(0x1012_967e, 5); calld(0x1007_5fdc, -0xb_36a7);          /* call 0x10075fdc */
            ii(0x1012_9683, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9686, 4); mov(memw_a32[ds, edx + 0x40], ax);      /* mov [edx+0x40], ax */
            ii(0x1012_968a, 5); mov(eax, 0x2c);                         /* mov eax, 0x2c */
            ii(0x1012_968f, 5); calld(0x1007_5fdc, -0xb_36b8);          /* call 0x10075fdc */
            ii(0x1012_9694, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_9697, 4); mov(memw_a32[ds, edx + 0x42], ax);      /* mov [edx+0x42], ax */
            ii(0x1012_969b, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_96a0, 5); calld(0x1012_5be9, -0x3abc);            /* call 0x10125be9 */
            ii(0x1012_96a5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_96a7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_96a8, 1); popd(edi);                              /* pop edi */
            ii(0x1012_96a9, 1); popd(esi);                              /* pop esi */
            ii(0x1012_96aa, 1); popd(edx);                              /* pop edx */
            ii(0x1012_96ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_96ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_96ad, 1); retd(); return;                         /* ret */
        }
    }
}
