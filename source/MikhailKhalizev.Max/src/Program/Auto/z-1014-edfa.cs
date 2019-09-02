using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_edfa-bba96fd8")]
        public void Method_1014_edfa()
        {
            ii(0x1014_edfa, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1014_edff, 5); call(Definitions.sys_check_available_stack_size, 0x1_6f4e); /* call 0x10165d52 */
            ii(0x1014_ee04, 1); push(ebx);                              /* push ebx */
            ii(0x1014_ee05, 1); push(ecx);                              /* push ecx */
            ii(0x1014_ee06, 1); push(esi);                              /* push esi */
            ii(0x1014_ee07, 1); push(edi);                              /* push edi */
            ii(0x1014_ee08, 1); push(ebp);                              /* push ebp */
            ii(0x1014_ee09, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_ee0b, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1014_ee11, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_ee14, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_ee17, 4); or(memb[ss, ebp - 0xc], 1);             /* or byte [ebp-0xc], 0x1 */
            ii(0x1014_ee1b, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1014_ee1e, 5); call(Definitions.my_ctor_0x101b_38f8, -0xd_8733); /* call 0x100766f0 */
            ii(0x1014_ee23, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1014_ee26, 4); and(memb[ss, ebp - 0xc], -2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1014_ee2a, 5); mov(eax, 0xe1);                         /* mov eax, 0xe1 */
            ii(0x1014_ee2f, 5); call(Definitions.sys_new, 0x1_6fcc);    /* call 0x10165e00 */
            ii(0x1014_ee34, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_ee37, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_ee3a, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_ee3d, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1014_ee41, 2); if(jz(0x1014_ee59, 0x16)) goto l_0x1014_ee59; /* jz 0x1014ee59 */
            ii(0x1014_ee43, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_ee46, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_ee49, 5); call(0x1014_8bc2, -0x628c);             /* call 0x10148bc2 */
            ii(0x1014_ee4e, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_ee51, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_ee54, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_ee57, 2); jmp(0x1014_ee5f, 6); goto l_0x1014_ee5f; /* jmp 0x1014ee5f */
        l_0x1014_ee59:
            ii(0x1014_ee59, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_ee5c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1014_ee5f:
            ii(0x1014_ee5f, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_ee62, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1014_ee65, 5); call(0x1007_6630, -0xd_883a);           /* call 0x10076630 */
            ii(0x1014_ee6a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ee6c, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1014_ee6f, 5); call(0x1007_6574, -0xd_8900);           /* call 0x10076574 */
            ii(0x1014_ee74, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_ee77, 5); call(0x1007_6a34, -0xd_8448);           /* call 0x10076a34 */
            ii(0x1014_ee7c, 3); lea(edx, memd[ss, ebp - 0x24]);         /* lea edx, [ebp-0x24] */
            ii(0x1014_ee7f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_ee82, 5); call(0x1007_6668, -0xd_881f);           /* call 0x10076668 */
            ii(0x1014_ee87, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ee89, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1014_ee8c, 5); call(0x1007_5f2c, -0xd_8f65);           /* call 0x10075f2c */
            ii(0x1014_ee91, 2); jmp(0x1014_ee9d, 0xa); goto l_0x1014_ee9d; /* jmp 0x1014ee9d */
        //  ii(0x1014_ee93, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_ee95, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
        //  ii(0x1014_ee98, 5); call(0x1007_5f2c, -0xd_8f71);           /* call 0x10075f2c */
        l_0x1014_ee9d:
            ii(0x1014_ee9d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_eea0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_eea2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_eea3, 1); pop(edi);                               /* pop edi */
            ii(0x1014_eea4, 1); pop(esi);                               /* pop esi */
            ii(0x1014_eea5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_eea6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_eea7, 1); ret();                                  /* ret */
        }
    }
}
