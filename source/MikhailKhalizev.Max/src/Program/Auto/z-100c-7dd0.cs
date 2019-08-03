using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("76d8c63e-4ba7-4e84-84d2-624c253625e2")]
        public void Method_100c_7dd0()
        {
            ii(0x100c_7dd0, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x100c_7dd5, 5); calld(Definitions.sys_check_available_stack_size, 0x9df78); /* call 0x10165d52 */
            ii(0x100c_7dda, 1); pushd(esi);                             /* push esi */
            ii(0x100c_7ddb, 1); pushd(edi);                             /* push edi */
            ii(0x100c_7ddc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_7ddd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_7ddf, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x100c_7de5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_7de8, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100c_7deb, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_7dee, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100c_7df1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7df4, 5); calld(0x1013_aaa8, 0x72caf);            /* call 0x1013aaa8 */
            ii(0x100c_7df9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_7dfc, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_7dff, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_7e02, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7e05, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100c_7e08, 5); calld(Definitions.my_ctor_0x101b4184, -0x5131d); /* call 0x10076af0 */
            ii(0x100c_7e0d, 3); sub(eax, 0x1b);                         /* sub eax, 0x1b */
            ii(0x100c_7e10, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_7e13, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7e16, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_58e8); /* mov dword [eax+0x2], 0x101b58e8 */
            ii(0x100c_7e1d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_7e1f, 3); mov(bl, memb_a32[ss, ebp - 0x4]);       /* mov bl, [ebp-0x4] */
            ii(0x100c_7e22, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_7e25, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100c_7e28, 5); calld(0x100c_7b68, -0x2c5);             /* call 0x100c7b68 */
            ii(0x100c_7e2d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_7e30, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7e33, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100c_7e36, 5); calld(0x1008_8b44, -0x3f2f7);           /* call 0x10088b44 */
            ii(0x100c_7e3b, 3); mov(al, memb_a32[ss, ebp + 0x10]);      /* mov al, [ebp+0x10] */
            ii(0x100c_7e3e, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100c_7e41, 3); mov(memb_a32[ds, edx + 0x23], al);      /* mov [edx+0x23], al */
            ii(0x100c_7e44, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_7e47, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100c_7e4a, 4); mov(memw_a32[ds, edx + 0x7], ax);       /* mov [edx+0x7], ax */
            ii(0x100c_7e4e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7e51, 6); mov(memw_a32[ds, eax + 0x9], 0);        /* mov word [eax+0x9], 0x0 */
            ii(0x100c_7e57, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_7e5a, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100c_7e5d, 3); mov(memd_a32[ds, edx + 0x1f], eax);     /* mov [edx+0x1f], eax */
            ii(0x100c_7e60, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7e63, 4); mov(memb_a32[ds, eax + 0x6], 0);        /* mov byte [eax+0x6], 0x0 */
            ii(0x100c_7e67, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_7e6a, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100c_7e6d, 5); calld(0x1007_5e64, -0x5200e);           /* call 0x10075e64 */
            ii(0x100c_7e72, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_7e74, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100c_7e77, 5); calld(0x1009_034f, -0x37b2d);           /* call 0x1009034f */
            ii(0x100c_7e7c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_7e7e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7e81, 4); mov(memw_a32[ds, eax + 0x9], dx);       /* mov [eax+0x9], dx */
            ii(0x100c_7e85, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100c_7e88, 5); calld(0x1009_c390, -0x2bafd);           /* call 0x1009c390 */
            ii(0x100c_7e8d, 3); mov(edi, memd_a32[ss, ebp - 0x10]);     /* mov edi, [ebp-0x10] */
            ii(0x100c_7e90, 3); lea(edi, edi + 0xb);                    /* lea edi, [edi+0xb] */
            ii(0x100c_7e93, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100c_7e95, 1); movsd_a32();                            /* movsd */
            ii(0x100c_7e96, 1); movsd_a32();                            /* movsd */
            ii(0x100c_7e97, 1); movsd_a32();                            /* movsd */
            ii(0x100c_7e98, 1); movsd_a32();                            /* movsd */
            ii(0x100c_7e99, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7e9c, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100c_7e9f, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100c_7ea2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_7ea4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_7ea5, 1); popd(edi);                              /* pop edi */
            ii(0x100c_7ea6, 1); popd(esi);                              /* pop esi */
            ii(0x100c_7ea7, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}