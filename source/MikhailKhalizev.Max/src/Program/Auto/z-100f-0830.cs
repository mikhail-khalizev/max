using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_0830-78d8d2aa")]
        public void Method_100f_0830()
        {
            ii(0x100f_0830, 5); push(0x58);                             /* push 0x58 */
            ii(0x100f_0835, 5); call(Definitions.sys_check_available_stack_size, 0x7_5518); /* call 0x10165d52 */
            ii(0x100f_083a, 1); push(ebx);                              /* push ebx */
            ii(0x100f_083b, 1); push(ecx);                              /* push ecx */
            ii(0x100f_083c, 1); push(edx);                              /* push edx */
            ii(0x100f_083d, 1); push(esi);                              /* push esi */
            ii(0x100f_083e, 1); push(edi);                              /* push edi */
            ii(0x100f_083f, 1); push(ebp);                              /* push ebp */
            ii(0x100f_0840, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_0842, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100f_0848, 5); mov(eax, 0x101b_8734);                  /* mov eax, 0x101b8734 */
            ii(0x100f_084d, 5); call(/* sys */ 0x1016_611f, 0x7_58cd);  /* call 0x1016611f */
            ii(0x100f_0852, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_0854, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_0859, 5); call(0x1007_66ac, -0x7_a1b2);           /* call 0x100766ac */
            ii(0x100f_085e, 7); mov(memd[ss, ebp - 0x20], 0x3039);      /* mov dword [ebp-0x20], 0x3039 */
            ii(0x100f_0865, 10); mov(memd[ds, 0x101b_873c], 1);         /* mov dword [0x101b873c], 0x1 */
            ii(0x100f_086f, 5); mov(eax, 0x101c_37c0);                  /* mov eax, 0x101c37c0 */
            ii(0x100f_0874, 5); call(Definitions.my_ctor_0x101b_38f8, -0x7_a189); /* call 0x100766f0 */
            ii(0x100f_0879, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100f_087c, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100f_087f, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_0882, 10); mov(memd[ds, 0x101b_873c], 2);         /* mov dword [0x101b873c], 0x2 */
            ii(0x100f_088c, 5); mov(eax, 0x101c_37c4);                  /* mov eax, 0x101c37c4 */
            ii(0x100f_0891, 5); call(Definitions.my_ctor_0x101b_38f8, -0x7_a1a6); /* call 0x100766f0 */
            ii(0x100f_0896, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100f_0899, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100f_089c, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_089f, 10); mov(memd[ds, 0x101b_873c], 3);         /* mov dword [0x101b873c], 0x3 */
            ii(0x100f_08a9, 5); mov(eax, 0x101c_38b4);                  /* mov eax, 0x101c38b4 */
            ii(0x100f_08ae, 5); call(Definitions.my_ctor_0x101b_38f8, -0x7_a1c3); /* call 0x100766f0 */
            ii(0x100f_08b3, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100f_08b6, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100f_08b9, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_08bc, 10); mov(memd[ds, 0x101b_873c], 4);         /* mov dword [0x101b873c], 0x4 */
            ii(0x100f_08c6, 5); mov(eax, 0x101c_38bc);                  /* mov eax, 0x101c38bc */
            ii(0x100f_08cb, 5); call(Definitions.my_ctor_0x101b_38f8, -0x7_a1e0); /* call 0x100766f0 */
            ii(0x100f_08d0, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100f_08d3, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100f_08d6, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_08d9, 10); mov(memd[ds, 0x101b_873c], 5);         /* mov dword [0x101b873c], 0x5 */
            ii(0x100f_08e3, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_08e8, 5); call(Definitions.my_ctor_0x101b_56fc, -0x6_7c71); /* call 0x10088c7c */
            ii(0x100f_08ed, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100f_08f0, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100f_08f3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_08f6, 10); mov(memd[ds, 0x101b_873c], 6);         /* mov dword [0x101b873c], 0x6 */
            ii(0x100f_0900, 5); mov(eax, 0x101c_3990);                  /* mov eax, 0x101c3990 */
            ii(0x100f_0905, 5); call(0x100f_12c2, 0x9b8);               /* call 0x100f12c2 */
            ii(0x100f_090a, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100f_090d, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100f_0910, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_0913, 10); mov(memd[ds, 0x101b_873c], 7);         /* mov dword [0x101b873c], 0x7 */
            ii(0x100f_091d, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_0922, 5); call(Definitions.my_string_ctor, 0x5_11c1); /* call 0x10141ae8 */
            ii(0x100f_0927, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100f_092a, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100f_092d, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100f_0930, 10); mov(memd[ds, 0x101b_873c], 8);         /* mov dword [0x101b873c], 0x8 */
            ii(0x100f_093a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_093c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_093d, 1); pop(edi);                               /* pop edi */
            ii(0x100f_093e, 1); pop(esi);                               /* pop esi */
            ii(0x100f_093f, 1); pop(edx);                               /* pop edx */
            ii(0x100f_0940, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_0941, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_0942, 1); ret();                                  /* ret */
        }
    }
}
