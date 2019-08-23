using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_c58b-2ff04862")]
        public void Method_100f_c58b()
        {
            ii(0x100f_c58b, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100f_c590, 5); calld(Definitions.sys_check_available_stack_size, 0x6_97bd); /* call 0x10165d52 */
            ii(0x100f_c595, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_c596, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_c597, 1); pushd(esi);                             /* push esi */
            ii(0x100f_c598, 1); pushd(edi);                             /* push edi */
            ii(0x100f_c599, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_c59a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_c59c, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100f_c5a2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_c5a5, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100f_c5a8, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100f_c5af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_c5b2, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100f_c5b7, 1); cwde();                                 /* cwde */
            ii(0x100f_c5b8, 1); pushd(eax);                             /* push eax */
            ii(0x100f_c5b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c5bc, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100f_c5c1, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_c5c4, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_c5c8, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_c5cc, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_c5cf, 5); calld(0x1008_b148, -0x7_148c);          /* call 0x1008b148 */
            ii(0x100f_c5d4, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100f_c5d8, 2); if(jged(0x100f_c5e1, 0x7)) goto l_0x100f_c5e1; /* jge 0x100fc5e1 */
            ii(0x100f_c5da, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
        l_0x100f_c5e1:
            ii(0x100f_c5e1, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100f_c5e5, 2); if(jged(0x100f_c5ee, 0x7)) goto l_0x100f_c5ee; /* jge 0x100fc5ee */
            ii(0x100f_c5e7, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x100f_c5ee:
            ii(0x100f_c5ee, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x100f_c5f3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c5f6, 3); cmp(eax, memd_a32[ss, ebp - 0x14]);     /* cmp eax, [ebp-0x14] */
            ii(0x100f_c5f9, 2); if(jged(0x100f_c606, 0xb)) goto l_0x100f_c606; /* jge 0x100fc606 */
            ii(0x100f_c5fb, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x100f_c600, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c603, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x100f_c606:
            ii(0x100f_c606, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100f_c60b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c60e, 3); cmp(eax, memd_a32[ss, ebp - 0x10]);     /* cmp eax, [ebp-0x10] */
            ii(0x100f_c611, 2); if(jged(0x100f_c61e, 0xb)) goto l_0x100f_c61e; /* jge 0x100fc61e */
            ii(0x100f_c613, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100f_c618, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c61b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100f_c61e:
            ii(0x100f_c61e, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_c621, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_c624, 2); jmpd(0x100f_c62c, 0x6); goto l_0x100f_c62c; /* jmp 0x100fc62c */
        l_0x100f_c626:
            ii(0x100f_c626, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c629, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100f_c62c:
            ii(0x100f_c62c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_c630, 3); cmp(eax, memd_a32[ss, ebp - 0x14]);     /* cmp eax, [ebp-0x14] */
            ii(0x100f_c633, 2); if(jged(0x100f_c67b, 0x46)) goto l_0x100f_c67b; /* jge 0x100fc67b */
            ii(0x100f_c635, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_c638, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_c63b, 2); jmpd(0x100f_c643, 0x6); goto l_0x100f_c643; /* jmp 0x100fc643 */
        l_0x100f_c63d:
            ii(0x100f_c63d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_c640, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x100f_c643:
            ii(0x100f_c643, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_c647, 3); cmp(eax, memd_a32[ss, ebp - 0x10]);     /* cmp eax, [ebp-0x10] */
            ii(0x100f_c64a, 2); if(jged(0x100f_c679, 0x2d)) goto l_0x100f_c679; /* jge 0x100fc679 */
            ii(0x100f_c64c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_c650, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100f_c656, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_c659, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_c65c, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_c660, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_c662, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_c664, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x100f_c66a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_c66c, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100f_c66f, 5); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x100f_c674, 3); add(memd_a32[ss, ebp - 0xc], eax);      /* add [ebp-0xc], eax */
            ii(0x100f_c677, 2); jmpd(0x100f_c63d, -0x3c); goto l_0x100f_c63d; /* jmp 0x100fc63d */
        l_0x100f_c679:
            ii(0x100f_c679, 2); jmpd(0x100f_c626, -0x55); goto l_0x100f_c626; /* jmp 0x100fc626 */
        l_0x100f_c67b:
            ii(0x100f_c67b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_c67e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100f_c681, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_c684, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_c686, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_c687, 1); popd(edi);                              /* pop edi */
            ii(0x100f_c688, 1); popd(esi);                              /* pop esi */
            ii(0x100f_c689, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_c68a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_c68b, 1); retd();                                 /* ret */
        }
    }
}
