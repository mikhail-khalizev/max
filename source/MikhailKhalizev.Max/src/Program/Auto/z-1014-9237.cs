using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c5612466-ce6a-49e3-b7c8-8831d8307232")]
        public void Method_1014_9237()
        {
            ii(0x1014_9237, 5); pushd(0x50);                            /* push 0x50 */
            ii(0x1014_923c, 5); calld(Definitions.sys_check_available_stack_size, 0x1_cb11); /* call 0x10165d52 */
            ii(0x1014_9241, 1); pushd(esi);                             /* push esi */
            ii(0x1014_9242, 1); pushd(edi);                             /* push edi */
            ii(0x1014_9243, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_9244, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_9246, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1014_924c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_924f, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1014_9252, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_9255, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1014_9258, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_925b, 5); calld(0x1014_4ef4, -0x436c);            /* call 0x10144ef4 */
            ii(0x1014_9260, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_9263, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_9266, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_9269, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_926c, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_926f, 5); calld(0x1012_0d24, -0x2_8550);          /* call 0x10120d24 */
            ii(0x1014_9274, 3); sub(eax, 0x65);                         /* sub eax, 0x65 */
            ii(0x1014_9277, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_927a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_927d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_9280, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9283, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_9286, 5); calld(Definitions.my_ctor_0x101b_38d0, -0xd_2a47); /* call 0x10076844 */
            ii(0x1014_928b, 3); sub(eax, 0x6c);                         /* sub eax, 0x6c */
            ii(0x1014_928e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_9291, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_9294, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_9297, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_929a, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_929d, 5); calld(0x1007_6998, -0xd_290a);          /* call 0x10076998 */
            ii(0x1014_92a2, 3); sub(eax, 0x70);                         /* sub eax, 0x70 */
            ii(0x1014_92a5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_92a8, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_92ab, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_92ae, 5); calld(0x1008_b3ec, -0xb_dec7);          /* call 0x1008b3ec */
            ii(0x1014_92b3, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_92b6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_92b9, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_92bc, 5); calld(0x1008_b1e4, -0xb_e0dd);          /* call 0x1008b1e4 */
            ii(0x1014_92c1, 3); sub(eax, 0x74);                         /* sub eax, 0x74 */
            ii(0x1014_92c4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_92c7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_92ca, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1014_92cd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_92d0, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_92d5, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xd_2bea); /* call 0x100766f0 */
            ii(0x1014_92da, 5); sub(eax, 0x82);                         /* sub eax, 0x82 */
            ii(0x1014_92df, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_92e2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_92e5, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1014_92e8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_92eb, 5); add(eax, 0x86);                         /* add eax, 0x86 */
            ii(0x1014_92f0, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xd_2c05); /* call 0x100766f0 */
            ii(0x1014_92f5, 5); sub(eax, 0x86);                         /* sub eax, 0x86 */
            ii(0x1014_92fa, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_92fd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_9300, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1014_9303, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9306, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1014_930b, 5); calld(0x1009_ca70, -0xa_c8a0);          /* call 0x1009ca70 */
            ii(0x1014_9310, 5); sub(eax, 0x8a);                         /* sub eax, 0x8a */
            ii(0x1014_9315, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_9318, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_931b, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1014_931e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9321, 5); add(eax, 0x94);                         /* add eax, 0x94 */
            ii(0x1014_9326, 5); calld(0x1009_ca70, -0xa_c8bb);          /* call 0x1009ca70 */
            ii(0x1014_932b, 5); sub(eax, 0x94);                         /* sub eax, 0x94 */
            ii(0x1014_9330, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_9333, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_9336, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1014_9339, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_933c, 5); add(eax, 0x9f);                         /* add eax, 0x9f */
            ii(0x1014_9341, 5); calld(Definitions.my_ctor_0x101b_4184, -0xd_2856); /* call 0x10076af0 */
            ii(0x1014_9346, 5); sub(eax, 0x9f);                         /* sub eax, 0x9f */
            ii(0x1014_934b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_934e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9351, 5); add(eax, 0xd9);                         /* add eax, 0xd9 */
            ii(0x1014_9356, 5); calld(Definitions.my_ctor_0x101b_4184, -0xd_286b); /* call 0x10076af0 */
            ii(0x1014_935b, 5); sub(eax, 0xd9);                         /* sub eax, 0xd9 */
            ii(0x1014_9360, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_9363, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9366, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_7398); /* mov dword [eax+0x2], 0x101b7398 */
            ii(0x1014_936d, 7); inc(memw_a32[ds, 0x101c_8148]);         /* inc word [0x101c8148] */
            ii(0x1014_9374, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9377, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
            ii(0x1014_937b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_937e, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1014_9382, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9385, 4); mov(memb_a32[ds, eax + 0x3f], 0);       /* mov byte [eax+0x3f], 0x0 */
            ii(0x1014_9389, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_938c, 4); mov(memb_a32[ds, eax + 0x40], 0x1);     /* mov byte [eax+0x40], 0x1 */
            ii(0x1014_9390, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9393, 7); mov(memb_a32[ds, eax + 0xa6], 0);       /* mov byte [eax+0xa6], 0x0 */
            ii(0x1014_939a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_939d, 6); mov(memw_a32[ds, eax + 0x41], 0);       /* mov word [eax+0x41], 0x0 */
            ii(0x1014_93a3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93a6, 6); mov(memw_a32[ds, eax + 0x43], 0);       /* mov word [eax+0x43], 0x0 */
            ii(0x1014_93ac, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93af, 4); mov(memb_a32[ds, eax + 0x46], 0);       /* mov byte [eax+0x46], 0x0 */
            ii(0x1014_93b3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93b6, 4); mov(memb_a32[ds, eax + 0x47], 0);       /* mov byte [eax+0x47], 0x0 */
            ii(0x1014_93ba, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93bd, 4); mov(memb_a32[ds, eax + 0x48], 0);       /* mov byte [eax+0x48], 0x0 */
            ii(0x1014_93c1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93c4, 4); mov(memb_a32[ds, eax + 0x49], 0);       /* mov byte [eax+0x49], 0x0 */
            ii(0x1014_93c8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93cb, 4); mov(memb_a32[ds, eax + 0x4a], 0);       /* mov byte [eax+0x4a], 0x0 */
            ii(0x1014_93cf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93d2, 4); mov(memb_a32[ds, eax + 0x4b], 0);       /* mov byte [eax+0x4b], 0x0 */
            ii(0x1014_93d6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93d9, 4); mov(memb_a32[ds, eax + 0x4c], 0);       /* mov byte [eax+0x4c], 0x0 */
            ii(0x1014_93dd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93e0, 7); mov(memd_a32[ds, eax + 0xa], 0);        /* mov dword [eax+0xa], 0x0 */
            ii(0x1014_93e7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93ea, 7); mov(memd_a32[ds, eax + 0xe], 0);        /* mov dword [eax+0xe], 0x0 */
            ii(0x1014_93f1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93f4, 7); mov(memb_a32[ds, eax + 0x9e], 0);       /* mov byte [eax+0x9e], 0x0 */
            ii(0x1014_93fb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_93fe, 9); mov(memw_a32[ds, eax + 0xa3], 0);       /* mov word [eax+0xa3], 0x0 */
            ii(0x1014_9407, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_940a, 10); mov(memd_a32[ds, eax + 0xa7], 0);      /* mov dword [eax+0xa7], 0x0 */
            ii(0x1014_9414, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_9417, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_941a, 4); mov(memw_a32[ds, edx + 0x8], ax);       /* mov [edx+0x8], ax */
            ii(0x1014_941e, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1014_9421, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_9424, 3); mov(memb_a32[ds, edx + 0x26], al);      /* mov [edx+0x26], al */
            ii(0x1014_9427, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_942a, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_942d, 4); mov(memw_a32[ds, edx + 0x7c], ax);      /* mov [edx+0x7c], ax */
            ii(0x1014_9431, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9434, 4); mov(memb_a32[ds, eax + 0x5b], 0);       /* mov byte [eax+0x5b], 0x0 */
            ii(0x1014_9438, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_943b, 4); mov(memb_a32[ds, eax + 0x57], 0);       /* mov byte [eax+0x57], 0x0 */
            ii(0x1014_943f, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1014_9443, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_9447, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_944d, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x1014_9452, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1014_9454, 5); calld(0x100d_fd2c, -0x6_972d);          /* call 0x100dfd2c */
            ii(0x1014_9459, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_945b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_945e, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_9461, 5); calld(0x100c_b77c, -0x7_dcea);          /* call 0x100cb77c */
            ii(0x1014_9466, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9469, 4); mov(memb_a32[ds, eax + 0x27], 0);       /* mov byte [eax+0x27], 0x0 */
            ii(0x1014_946d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9470, 6); mov(memw_a32[ds, eax + 0x78], 0x1);     /* mov word [eax+0x78], 0x1 */
            ii(0x1014_9476, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9479, 10); mov(memd_a32[ds, eax + 0xdd], 0);      /* mov dword [eax+0xdd], 0x0 */
            ii(0x1014_9483, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9486, 4); mov(memb_a32[ds, eax + 0x7b], 0);       /* mov byte [eax+0x7b], 0x0 */
            ii(0x1014_948a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_948d, 4); mov(memb_a32[ds, eax + 0x45], 0);       /* mov byte [eax+0x45], 0x0 */
            ii(0x1014_9491, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9494, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_9497, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_949a, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_949d, 6); mov(edx, memd_a32[ds, eax + 0x101c_81c0]); /* mov edx, [eax+0x101c81c0] */
            ii(0x1014_94a3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_94a6, 3); mov(memd_a32[ds, eax + 0x12], edx);     /* mov [eax+0x12], edx */
            ii(0x1014_94a9, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_94ad, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_94b3, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1014_94b9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_94bb, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x1014_94be, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_94c1, 3); or(memd_a32[ds, eax + 0x12], edx);      /* or [eax+0x12], edx */
            ii(0x1014_94c4, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_94c8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_94ce, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1014_94d4, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1014_94d7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_94da, 3); mov(memd_a32[ds, eax + 0x22], edx);     /* mov [eax+0x22], edx */
            ii(0x1014_94dd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_94e0, 4); mov(memb_a32[ds, eax + 0x28], 0xff);    /* mov byte [eax+0x28], 0xff */
            ii(0x1014_94e4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_94e7, 4); mov(memb_a32[ds, eax + 0x59], 0);       /* mov byte [eax+0x59], 0x0 */
            ii(0x1014_94eb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_94ee, 4); mov(memb_a32[ds, eax + 0x5a], 0);       /* mov byte [eax+0x5a], 0x0 */
            ii(0x1014_94f2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_94f5, 4); mov(memb_a32[ds, eax + 0x7a], 0);       /* mov byte [eax+0x7a], 0x0 */
            ii(0x1014_94f9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_94fc, 7); mov(memb_a32[ds, eax + 0xa5], 0x1);     /* mov byte [eax+0xa5], 0x1 */
            ii(0x1014_9503, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9506, 4); mov(memb_a32[ds, eax + 0x64], 0);       /* mov byte [eax+0x64], 0x0 */
            ii(0x1014_950a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_950d, 6); mov(memw_a32[ds, eax + 0x69], 0);       /* mov word [eax+0x69], 0x0 */
            ii(0x1014_9513, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9516, 4); mov(memb_a32[ds, eax + 0x2d], 0);       /* mov byte [eax+0x2d], 0x0 */
            ii(0x1014_951a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_951c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_951f, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_9524, 5); calld(0x1007_6630, -0xd_2ef9);          /* call 0x10076630 */
            ii(0x1014_9529, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_952c, 4); mov(memb_a32[ds, eax + 0x5d], 0);       /* mov byte [eax+0x5d], 0x0 */
            ii(0x1014_9530, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9533, 4); mov(memb_a32[ds, eax + 0x2b], 0);       /* mov byte [eax+0x2b], 0x0 */
            ii(0x1014_9537, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_953a, 4); mov(memb_a32[ds, eax + 0x2c], 0);       /* mov byte [eax+0x2c], 0x0 */
            ii(0x1014_953e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9541, 7); mov(memd_a32[ds, eax + 0x7e], 0);       /* mov dword [eax+0x7e], 0x0 */
            ii(0x1014_9548, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_954b, 4); mov(memb_a32[ds, eax + 0x4f], 0);       /* mov byte [eax+0x4f], 0x0 */
            ii(0x1014_954f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9552, 9); mov(memw_a32[ds, eax + 0xd9], 0);       /* mov word [eax+0xd9], 0x0 */
            ii(0x1014_955b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_955e, 9); mov(memw_a32[ds, eax + 0xdb], 0);       /* mov word [eax+0xdb], 0x0 */
            ii(0x1014_9567, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_956a, 4); mov(memb_a32[ds, eax + 0x5c], 0);       /* mov byte [eax+0x5c], 0x0 */
            ii(0x1014_956e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9571, 5); calld(0x1015_b336, 0x1_1dc0);           /* call 0x1015b336 */
            ii(0x1014_9576, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1014_957a, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_957d, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x1014_9582, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_9584, 3); mov(memd_a32[ss, ebp - 0x38], edx);     /* mov [ebp-0x38], edx */
            ii(0x1014_9587, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1014_958a, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x1014_958d, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1014_9590, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1014_9593, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1014_9596, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_9599, 4); mov(memw_a32[ds, edx + 0x31], ax);      /* mov [edx+0x31], ax */
            ii(0x1014_959d, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1014_95a0, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_95a3, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1014_95a5, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_95a7, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_95aa, 4); mov(memw_a32[ds, edx + 0x33], ax);      /* mov [edx+0x33], ax */
            ii(0x1014_95ae, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1014_95b1, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_95b4, 3); mov(al, memb_a32[ds, eax + 0x2]);       /* mov al, [eax+0x2] */
            ii(0x1014_95b7, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_95b9, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_95bc, 4); mov(memw_a32[ds, edx + 0x35], ax);      /* mov [edx+0x35], ax */
            ii(0x1014_95c0, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1014_95c3, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_95c6, 3); mov(al, memb_a32[ds, eax + 0x4]);       /* mov al, [eax+0x4] */
            ii(0x1014_95c9, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_95cb, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_95ce, 4); mov(memw_a32[ds, edx + 0x37], ax);      /* mov [edx+0x37], ax */
            ii(0x1014_95d2, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1014_95d5, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_95d8, 3); mov(al, memb_a32[ds, eax + 0x6]);       /* mov al, [eax+0x6] */
            ii(0x1014_95db, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_95dd, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_95e0, 4); mov(memw_a32[ds, edx + 0x39], ax);      /* mov [edx+0x39], ax */
            ii(0x1014_95e4, 5); cmp(memw_a32[ss, ebp - 0xc], 0x28);     /* cmp word [ebp-0xc], 0x28 */
            ii(0x1014_95e9, 2); if(jnzd(0x1014_9610, 0x25)) goto l_0x1014_9610; /* jnz 0x10149610 */
            ii(0x1014_95eb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_95ee, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_95f1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_95f6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_95fc, 6); mov(al, memb_a32[ds, eax + 0x101c_a4ef]); /* mov al, [eax+0x101ca4ef] */
            ii(0x1014_9602, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_9604, 1); dec(eax);                               /* dec eax */
            ii(0x1014_9605, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_9607, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_9609, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_960c, 4); add(memw_a32[ds, eax + 0x33], dx);      /* add [eax+0x33], dx */
        l_0x1014_9610:
            ii(0x1014_9610, 3); mov(al, memb_a32[ss, ebp + 0x10]);      /* mov al, [ebp+0x10] */
            ii(0x1014_9613, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_9616, 3); mov(memb_a32[ds, edx + 0x29], al);      /* mov [edx+0x29], al */
            ii(0x1014_9619, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_961c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_961e, 3); mov(bl, memb_a32[ds, eax + 0x29]);      /* mov bl, [eax+0x29] */
            ii(0x1014_9621, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9624, 4); mov(dx, memw_a32[ds, eax + 0x33]);      /* mov dx, [eax+0x33] */
            ii(0x1014_9628, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_962b, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1014_962d, 7); mov(memw_a32[ds, eax + 0xd5], bx);      /* mov [eax+0xd5], bx */
            ii(0x1014_9634, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9637, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_9639, 3); mov(bl, memb_a32[ds, eax + 0x29]);      /* mov bl, [eax+0x29] */
            ii(0x1014_963c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_963f, 4); mov(dx, memw_a32[ds, eax + 0x35]);      /* mov dx, [eax+0x35] */
            ii(0x1014_9643, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9646, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1014_9648, 7); mov(memw_a32[ds, eax + 0xd7], bx);      /* mov [eax+0xd7], bx */
            ii(0x1014_964f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9652, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_9657, 2); if(jnzd(0x1014_9664, 0xb)) goto l_0x1014_9664; /* jnz 0x10149664 */
            ii(0x1014_9659, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_965c, 6); mov(memw_a32[ds, eax + 0x3b], 0x67);    /* mov word [eax+0x3b], 0x67 */
            ii(0x1014_9662, 2); jmpd(0x1014_9696, 0x32); goto l_0x1014_9696; /* jmp 0x10149696 */
        l_0x1014_9664:
            ii(0x1014_9664, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9667, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x1014_966c, 2); if(jnzd(0x1014_9679, 0xb)) goto l_0x1014_9679; /* jnz 0x10149679 */
            ii(0x1014_966e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9671, 6); mov(memw_a32[ds, eax + 0x3b], 0x67);    /* mov word [eax+0x3b], 0x67 */
            ii(0x1014_9677, 2); jmpd(0x1014_9696, 0x1d); goto l_0x1014_9696; /* jmp 0x10149696 */
        l_0x1014_9679:
            ii(0x1014_9679, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1014_967c, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_967f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_9681, 3); mov(dl, memb_a32[ds, eax + 0x1]);       /* mov dl, [eax+0x1] */
            ii(0x1014_9684, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9687, 7); add(dx, memw_a32[ds, eax + 0xd5]);      /* add dx, [eax+0xd5] */
            ii(0x1014_968e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9691, 1); dec(edx);                               /* dec edx */
            ii(0x1014_9692, 4); mov(memw_a32[ds, eax + 0x3b], dx);      /* mov [eax+0x3b], dx */
        l_0x1014_9696:
            ii(0x1014_9696, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9699, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_969c, 5); calld(0x1007_6730, -0xd_2f71);          /* call 0x10076730 */
            ii(0x1014_96a1, 3); mov(dl, memb_a32[ds, eax + 0xa]);       /* mov dl, [eax+0xa] */
            ii(0x1014_96a4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_96a7, 3); mov(memb_a32[ds, eax + 0x4d], dl);      /* mov [eax+0x4d], dl */
            ii(0x1014_96aa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_96ad, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_96b0, 5); calld(0x1007_6730, -0xd_2f85);          /* call 0x10076730 */
            ii(0x1014_96b5, 3); mov(dl, memb_a32[ds, eax + 0x10]);      /* mov dl, [eax+0x10] */
            ii(0x1014_96b8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_96bb, 3); mov(memb_a32[ds, eax + 0x4e], dl);      /* mov [eax+0x4e], dl */
            ii(0x1014_96be, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_96c1, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_96c4, 5); calld(0x1007_6730, -0xd_2f99);          /* call 0x10076730 */
            ii(0x1014_96c9, 3); mov(dl, memb_a32[ds, eax + 0x14]);      /* mov dl, [eax+0x14] */
            ii(0x1014_96cc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_96cf, 3); mov(memb_a32[ds, eax + 0x50], dl);      /* mov [eax+0x50], dl */
            ii(0x1014_96d2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_96d5, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_96d8, 5); calld(0x1007_6730, -0xd_2fad);          /* call 0x10076730 */
            ii(0x1014_96dd, 3); mov(dl, memb_a32[ds, eax + 0x16]);      /* mov dl, [eax+0x16] */
            ii(0x1014_96e0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_96e3, 3); mov(memb_a32[ds, eax + 0x51], dl);      /* mov [eax+0x51], dl */
            ii(0x1014_96e6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_96e9, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_96ec, 5); calld(0x1007_6730, -0xd_2fc1);          /* call 0x10076730 */
            ii(0x1014_96f1, 3); mov(dl, memb_a32[ds, eax + 0x1b]);      /* mov dl, [eax+0x1b] */
            ii(0x1014_96f4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_96f7, 3); mov(memb_a32[ds, eax + 0x54], dl);      /* mov [eax+0x54], dl */
            ii(0x1014_96fa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_96fd, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_9700, 5); calld(0x1007_6730, -0xd_2fd5);          /* call 0x10076730 */
            ii(0x1014_9705, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1014_9709, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_970c, 4); mov(memw_a32[ds, edx + 0x52], ax);      /* mov [edx+0x52], ax */
            ii(0x1014_9710, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9713, 4); mov(memb_a32[ds, eax + 0x60], 0x2);     /* mov byte [eax+0x60], 0x2 */
            ii(0x1014_9717, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_971a, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_971d, 5); calld(0x1007_6730, -0xd_2ff2);          /* call 0x10076730 */
            ii(0x1014_9722, 5); cmp(memw_a32[ds, eax + 0xe], 0);        /* cmp word [eax+0xe], 0x0 */
            ii(0x1014_9727, 2); if(jzd(0x1014_9732, 0x9)) goto l_0x1014_9732; /* jz 0x10149732 */
            ii(0x1014_9729, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_972c, 4); mov(memb_a32[ds, eax + 0x61], 0x2);     /* mov byte [eax+0x61], 0x2 */
            ii(0x1014_9730, 2); jmpd(0x1014_9739, 0x7); goto l_0x1014_9739; /* jmp 0x10149739 */
        l_0x1014_9732:
            ii(0x1014_9732, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9735, 4); mov(memb_a32[ds, eax + 0x61], 0);       /* mov byte [eax+0x61], 0x0 */
        l_0x1014_9739:
            ii(0x1014_9739, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_973c, 4); mov(memb_a32[ds, eax + 0x62], 0x2);     /* mov byte [eax+0x62], 0x2 */
            ii(0x1014_9740, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9743, 4); mov(memb_a32[ds, eax + 0x5e], 0);       /* mov byte [eax+0x5e], 0x0 */
            ii(0x1014_9747, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_974a, 4); mov(memb_a32[ds, eax + 0x5f], 0);       /* mov byte [eax+0x5f], 0x0 */
            ii(0x1014_974e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9751, 4); mov(memb_a32[ds, eax + 0x6b], 0);       /* mov byte [eax+0x6b], 0x0 */
            ii(0x1014_9755, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9758, 5); calld(0x1014_f1f2, 0x5a95);             /* call 0x1014f1f2 */
            ii(0x1014_975d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9760, 7); test(memd_a32[ds, eax + 0x12], 0x80_0018); /* test dword [eax+0x12], 0x800018 */
            ii(0x1014_9767, 2); if(jzd(0x1014_9772, 0x9)) goto l_0x1014_9772; /* jz 0x10149772 */
            ii(0x1014_9769, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_976c, 4); test(memb_a32[ds, eax + 0x12], 0x1);    /* test byte [eax+0x12], 0x1 */
            ii(0x1014_9770, 2); if(jzd(0x1014_9774, 0x2)) goto l_0x1014_9774; /* jz 0x10149774 */
        l_0x1014_9772:
            ii(0x1014_9772, 2); jmpd(0x1014_9787, 0x13); goto l_0x1014_9787; /* jmp 0x10149787 */
        l_0x1014_9774:
            ii(0x1014_9774, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9777, 4); mov(ax, memw_a32[ds, eax + 0x7c]);      /* mov ax, [eax+0x7c] */
            ii(0x1014_977b, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1014_9780, 5); cmp(eax, 0xffff);                       /* cmp eax, 0xffff */
            ii(0x1014_9785, 2); if(jnzd(0x1014_9789, 0x2)) goto l_0x1014_9789; /* jnz 0x10149789 */
        l_0x1014_9787:
            ii(0x1014_9787, 2); jmpd(0x1014_979e, 0x15); goto l_0x1014_979e; /* jmp 0x1014979e */
        l_0x1014_9789:
            ii(0x1014_9789, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_978d, 5); calld(0x1014_892b, -0xe67);             /* call 0x1014892b */
            ii(0x1014_9792, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1014_9795, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_9797, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_9799, 5); calld(0x1014_b9c9, 0x222b);             /* call 0x1014b9c9 */
        l_0x1014_979e:
            ii(0x1014_979e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_97a1, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1014_97a4, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1014_97a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_97a9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_97aa, 1); popd(edi);                              /* pop edi */
            ii(0x1014_97ab, 1); popd(esi);                              /* pop esi */
            ii(0x1014_97ac, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
