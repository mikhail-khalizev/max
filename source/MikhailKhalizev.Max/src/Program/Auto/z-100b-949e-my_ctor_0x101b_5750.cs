using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_949e-471b6a09")]
        public void my_ctor_0x101b_5750()
        {
            ii(0x100b_949e, 5); pushd(0xa0);                            /* push 0xa0 */
            ii(0x100b_94a3, 5); calld(Definitions.sys_check_available_stack_size, 0xa_c8aa); /* call 0x10165d52 */
            ii(0x100b_94a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_94a9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_94aa, 1); pushd(edx);                             /* push edx */
            ii(0x100b_94ab, 1); pushd(esi);                             /* push esi */
            ii(0x100b_94ac, 1); pushd(edi);                             /* push edi */
            ii(0x100b_94ad, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_94ae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_94b0, 6); sub(esp, 0x84);                         /* sub esp, 0x84 */
            ii(0x100b_94b6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_94b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_94bc, 3); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x100b_94bf, 5); calld(0x100c_7aeb, 0xe627);             /* call 0x100c7aeb */
            ii(0x100b_94c4, 3); sub(eax, 0x9);                          /* sub eax, 0x9 */
            ii(0x100b_94c7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_94ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_94cd, 3); add(eax, 0x11);                         /* add eax, 0x11 */
            ii(0x100b_94d0, 5); calld(0x100c_b588, 0x1_20b3);           /* call 0x100cb588 */
            ii(0x100b_94d5, 3); sub(eax, 0x11);                         /* sub eax, 0x11 */
            ii(0x100b_94d8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_94db, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_94de, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x100b_94e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_94e4, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_94e7, 5); calld(0x100c_b588, 0x1_209c);           /* call 0x100cb588 */
            ii(0x100b_94ec, 3); sub(eax, 0x15);                         /* sub eax, 0x15 */
            ii(0x100b_94ef, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_94f2, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_94f5, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x100b_94f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_94fb, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_94fe, 5); calld(Definitions.my_ctor_0x101b_3b58, -0x2_e45f); /* call 0x1008b0a4 */
            ii(0x100b_9503, 3); sub(eax, 0x19);                         /* sub eax, 0x19 */
            ii(0x100b_9506, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9509, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_950c, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x100b_950f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9512, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x100b_9515, 5); calld(Definitions.my_ctor_0x101b_3b58, -0x2_e476); /* call 0x1008b0a4 */
            ii(0x100b_951a, 3); sub(eax, 0x1d);                         /* sub eax, 0x1d */
            ii(0x100b_951d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9520, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_9523, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x100b_9526, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9529, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100b_952c, 5); calld(Definitions.my_ctor_0x101b_3b58, -0x2_e48d); /* call 0x1008b0a4 */
            ii(0x100b_9531, 3); sub(eax, 0x21);                         /* sub eax, 0x21 */
            ii(0x100b_9534, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9537, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_953a, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100b_953d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9540, 3); add(eax, 0x25);                         /* add eax, 0x25 */
            ii(0x100b_9543, 5); calld(Definitions.my_ctor_0x101b_3b58, -0x2_e4a4); /* call 0x1008b0a4 */
            ii(0x100b_9548, 3); sub(eax, 0x25);                         /* sub eax, 0x25 */
            ii(0x100b_954b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_954e, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_9551, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100b_9554, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9557, 3); add(eax, 0x29);                         /* add eax, 0x29 */
            ii(0x100b_955a, 5); calld(0x1009_ca70, -0x1_caef);          /* call 0x1009ca70 */
            ii(0x100b_955f, 3); sub(eax, 0x29);                         /* sub eax, 0x29 */
            ii(0x100b_9562, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9565, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_9568, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100b_956b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_956e, 3); add(eax, 0x33);                         /* add eax, 0x33 */
            ii(0x100b_9571, 5); calld(0x100c_b324, 0x1_1dae);           /* call 0x100cb324 */
            ii(0x100b_9576, 3); sub(eax, 0x33);                         /* sub eax, 0x33 */
            ii(0x100b_9579, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_957c, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_957f, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x100b_9582, 5); mov(ebx, 0x101b_3b58);                  /* mov ebx, 0x101b3b58 */
            ii(0x100b_9587, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x100b_958c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_958f, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x100b_9592, 5); calld(Definitions.sys_call_ctor_arr_v2, 0xa_c9d9); /* call 0x10165f70 */
            ii(0x100b_9597, 3); sub(eax, 0x37);                         /* sub eax, 0x37 */
            ii(0x100b_959a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_959d, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_95a0, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x100b_95a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_95a6, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100b_95a9, 5); calld(0x100c_b034, 0x1_1a86);           /* call 0x100cb034 */
            ii(0x100b_95ae, 3); sub(eax, 0x43);                         /* sub eax, 0x43 */
            ii(0x100b_95b1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_95b4, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_95b7, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x100b_95ba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_95bd, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100b_95c0, 5); calld(Definitions.my_ctor_0x101b_56fc, -0x3_0949); /* call 0x10088c7c */
            ii(0x100b_95c5, 3); sub(eax, 0x4d);                         /* sub eax, 0x4d */
            ii(0x100b_95c8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_95cb, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_95ce, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100b_95d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_95d4, 3); add(eax, 0x57);                         /* add eax, 0x57 */
            ii(0x100b_95d7, 5); calld(Definitions.my_ctor_0x101b_56fc, -0x3_0960); /* call 0x10088c7c */
            ii(0x100b_95dc, 3); sub(eax, 0x57);                         /* sub eax, 0x57 */
            ii(0x100b_95df, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_95e2, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_95e5, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100b_95e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_95eb, 3); add(eax, 0x6d);                         /* add eax, 0x6d */
            ii(0x100b_95ee, 5); calld(0x100c_b280, 0x1_1c8d);           /* call 0x100cb280 */
            ii(0x100b_95f3, 3); sub(eax, 0x6d);                         /* sub eax, 0x6d */
            ii(0x100b_95f6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_95f9, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_95fc, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100b_95ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9602, 3); add(eax, 0x77);                         /* add eax, 0x77 */
            ii(0x100b_9605, 5); calld(Definitions.my_ctor_0x101b_4184, -0x4_2b1a); /* call 0x10076af0 */
            ii(0x100b_960a, 3); sub(eax, 0x77);                         /* sub eax, 0x77 */
            ii(0x100b_960d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9610, 5); calld(0x1008_a4fc, -0x2_f119);          /* call 0x1008a4fc */
            ii(0x100b_9615, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_9618, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_961b, 3); add(eax, 0x7d);                         /* add eax, 0x7d */
            ii(0x100b_961e, 5); calld(0x100b_84c2, -0x1161);            /* call 0x100b84c2 */
            ii(0x100b_9623, 3); sub(eax, 0x7d);                         /* sub eax, 0x7d */
            ii(0x100b_9626, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9629, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_962c, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100b_962f, 5); calld(0x1008_a4fc, -0x2_f138);          /* call 0x1008a4fc */
            ii(0x100b_9634, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_9637, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_963a, 5); add(eax, 0x81);                         /* add eax, 0x81 */
            ii(0x100b_963f, 5); calld(0x100b_84c2, -0x1182);            /* call 0x100b84c2 */
            ii(0x100b_9644, 5); sub(eax, 0x81);                         /* sub eax, 0x81 */
            ii(0x100b_9649, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_964c, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_964f, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100b_9652, 5); calld(0x1008_a4fc, -0x2_f15b);          /* call 0x1008a4fc */
            ii(0x100b_9657, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_965a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_965d, 5); add(eax, 0x85);                         /* add eax, 0x85 */
            ii(0x100b_9662, 5); calld(0x100b_84c2, -0x11a5);            /* call 0x100b84c2 */
            ii(0x100b_9667, 5); sub(eax, 0x85);                         /* sub eax, 0x85 */
            ii(0x100b_966c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_966f, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_9672, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100b_9675, 5); calld(0x1008_a4fc, -0x2_f17e);          /* call 0x1008a4fc */
            ii(0x100b_967a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_967d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9680, 5); add(eax, 0x89);                         /* add eax, 0x89 */
            ii(0x100b_9685, 5); calld(0x100b_84c2, -0x11c8);            /* call 0x100b84c2 */
            ii(0x100b_968a, 5); sub(eax, 0x89);                         /* sub eax, 0x89 */
            ii(0x100b_968f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9692, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_9695, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100b_9698, 5); calld(0x1008_a4fc, -0x2_f1a1);          /* call 0x1008a4fc */
            ii(0x100b_969d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_96a0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_96a3, 5); add(eax, 0x8d);                         /* add eax, 0x8d */
            ii(0x100b_96a8, 5); calld(0x100b_84c2, -0x11eb);            /* call 0x100b84c2 */
            ii(0x100b_96ad, 5); sub(eax, 0x8d);                         /* sub eax, 0x8d */
            ii(0x100b_96b2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_96b5, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_96b8, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100b_96bb, 5); calld(0x1008_a4fc, -0x2_f1c4);          /* call 0x1008a4fc */
            ii(0x100b_96c0, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_96c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_96c6, 5); add(eax, 0x91);                         /* add eax, 0x91 */
            ii(0x100b_96cb, 5); calld(0x100b_84c2, -0x120e);            /* call 0x100b84c2 */
            ii(0x100b_96d0, 5); sub(eax, 0x91);                         /* sub eax, 0x91 */
            ii(0x100b_96d5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_96d8, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_96db, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100b_96de, 5); calld(0x1008_a4fc, -0x2_f1e7);          /* call 0x1008a4fc */
            ii(0x100b_96e3, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_96e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_96e9, 5); add(eax, 0x95);                         /* add eax, 0x95 */
            ii(0x100b_96ee, 5); calld(0x100b_84c2, -0x1231);            /* call 0x100b84c2 */
            ii(0x100b_96f3, 5); sub(eax, 0x95);                         /* sub eax, 0x95 */
            ii(0x100b_96f8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_96fb, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_96fe, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100b_9701, 5); calld(0x1008_a4fc, -0x2_f20a);          /* call 0x1008a4fc */
            ii(0x100b_9706, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_9709, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_970c, 5); add(eax, 0x99);                         /* add eax, 0x99 */
            ii(0x100b_9711, 5); calld(0x100b_84c2, -0x1254);            /* call 0x100b84c2 */
            ii(0x100b_9716, 5); sub(eax, 0x99);                         /* sub eax, 0x99 */
            ii(0x100b_971b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_971e, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_9721, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100b_9724, 5); calld(0x1008_a4fc, -0x2_f22d);          /* call 0x1008a4fc */
            ii(0x100b_9729, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_972c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_972f, 5); add(eax, 0x9d);                         /* add eax, 0x9d */
            ii(0x100b_9734, 5); calld(0x100b_84c2, -0x1277);            /* call 0x100b84c2 */
            ii(0x100b_9739, 5); sub(eax, 0x9d);                         /* sub eax, 0x9d */
            ii(0x100b_973e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9741, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_9744, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100b_9747, 5); calld(0x1008_a4fc, -0x2_f250);          /* call 0x1008a4fc */
            ii(0x100b_974c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_974f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9752, 5); add(eax, 0xa1);                         /* add eax, 0xa1 */
            ii(0x100b_9757, 5); calld(0x100b_84c2, -0x129a);            /* call 0x100b84c2 */
            ii(0x100b_975c, 5); sub(eax, 0xa1);                         /* sub eax, 0xa1 */
            ii(0x100b_9761, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9764, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_9767, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100b_976a, 5); calld(0x1008_a4fc, -0x2_f273);          /* call 0x1008a4fc */
            ii(0x100b_976f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_9772, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9775, 5); add(eax, 0xa5);                         /* add eax, 0xa5 */
            ii(0x100b_977a, 5); calld(0x100b_84c2, -0x12bd);            /* call 0x100b84c2 */
            ii(0x100b_977f, 5); sub(eax, 0xa5);                         /* sub eax, 0xa5 */
            ii(0x100b_9784, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9787, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_978a, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100b_978d, 5); calld(0x1008_a4fc, -0x2_f296);          /* call 0x1008a4fc */
            ii(0x100b_9792, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_9795, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9798, 5); add(eax, 0xa9);                         /* add eax, 0xa9 */
            ii(0x100b_979d, 5); calld(0x100b_84c2, -0x12e0);            /* call 0x100b84c2 */
            ii(0x100b_97a2, 5); sub(eax, 0xa9);                         /* sub eax, 0xa9 */
            ii(0x100b_97a7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_97aa, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_97ad, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_97b0, 5); calld(0x1008_a4fc, -0x2_f2b9);          /* call 0x1008a4fc */
            ii(0x100b_97b5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_97b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_97bb, 5); add(eax, 0xad);                         /* add eax, 0xad */
            ii(0x100b_97c0, 5); calld(0x100b_84c2, -0x1303);            /* call 0x100b84c2 */
            ii(0x100b_97c5, 5); sub(eax, 0xad);                         /* sub eax, 0xad */
            ii(0x100b_97ca, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_97cd, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_97d0, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_97d3, 5); calld(0x1008_a4fc, -0x2_f2dc);          /* call 0x1008a4fc */
            ii(0x100b_97d8, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_97db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_97de, 5); add(eax, 0xb1);                         /* add eax, 0xb1 */
            ii(0x100b_97e3, 5); calld(0x100b_84c2, -0x1326);            /* call 0x100b84c2 */
            ii(0x100b_97e8, 5); sub(eax, 0xb1);                         /* sub eax, 0xb1 */
            ii(0x100b_97ed, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_97f0, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_97f3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_97f6, 5); calld(0x1008_a4fc, -0x2_f2ff);          /* call 0x1008a4fc */
            ii(0x100b_97fb, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_97fe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9801, 5); add(eax, 0xb5);                         /* add eax, 0xb5 */
            ii(0x100b_9806, 5); calld(0x100b_84c2, -0x1349);            /* call 0x100b84c2 */
            ii(0x100b_980b, 5); sub(eax, 0xb5);                         /* sub eax, 0xb5 */
            ii(0x100b_9810, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9813, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_9816, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_9819, 5); calld(0x1008_a4fc, -0x2_f322);          /* call 0x1008a4fc */
            ii(0x100b_981e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_9821, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9824, 5); add(eax, 0xb9);                         /* add eax, 0xb9 */
            ii(0x100b_9829, 5); calld(0x100b_84c2, -0x136c);            /* call 0x100b84c2 */
            ii(0x100b_982e, 5); sub(eax, 0xb9);                         /* sub eax, 0xb9 */
            ii(0x100b_9833, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9836, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_9839, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_983c, 5); calld(0x1008_a4fc, -0x2_f345);          /* call 0x1008a4fc */
            ii(0x100b_9841, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_9844, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9847, 5); add(eax, 0xbd);                         /* add eax, 0xbd */
            ii(0x100b_984c, 5); calld(0x100b_84c2, -0x138f);            /* call 0x100b84c2 */
            ii(0x100b_9851, 5); sub(eax, 0xbd);                         /* sub eax, 0xbd */
            ii(0x100b_9856, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9859, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_985c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_985f, 5); calld(0x1008_a4fc, -0x2_f368);          /* call 0x1008a4fc */
            ii(0x100b_9864, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_9867, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_986a, 5); add(eax, 0xc1);                         /* add eax, 0xc1 */
            ii(0x100b_986f, 5); calld(0x100b_84c2, -0x13b2);            /* call 0x100b84c2 */
            ii(0x100b_9874, 5); sub(eax, 0xc1);                         /* sub eax, 0xc1 */
            ii(0x100b_9879, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_987c, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_987f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9882, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9885, 7); mov(memd_a32[ds, eax + 0x63], 0);       /* mov dword [eax+0x63], 0x0 */
            ii(0x100b_988c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_988f, 7); mov(memd_a32[ds, eax + 0x67], 0);       /* mov dword [eax+0x67], 0x0 */
            ii(0x100b_9896, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9899, 6); mov(memw_a32[ds, eax + 0x77], 0x1);     /* mov word [eax+0x77], 0x1 */
            ii(0x100b_989f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_98a2, 6); mov(memw_a32[ds, eax + 0x79], 0x1);     /* mov word [eax+0x79], 0x1 */
            ii(0x100b_98a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_98ab, 6); mov(memd_a32[ss, ebp - 0x84], eax);     /* mov [ebp-0x84], eax */
            ii(0x100b_98b1, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100b_98b7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_98b9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_98ba, 1); popd(edi);                              /* pop edi */
            ii(0x100b_98bb, 1); popd(esi);                              /* pop esi */
            ii(0x100b_98bc, 1); popd(edx);                              /* pop edx */
            ii(0x100b_98bd, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_98be, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_98bf, 1); retd(); return;                         /* ret */
        }
    }
}
