using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_989e-8c1d6144")]
        public void Method_1012_989e()
        {
            ii(0x1012_989e, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1012_98a3, 5); calld(Definitions.sys_check_available_stack_size, 0x3_c4aa); /* call 0x10165d52 */
            ii(0x1012_98a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_98a9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_98aa, 1); pushd(edx);                             /* push edx */
            ii(0x1012_98ab, 1); pushd(esi);                             /* push esi */
            ii(0x1012_98ac, 1); pushd(edi);                             /* push edi */
            ii(0x1012_98ad, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_98ae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_98b0, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_98b6, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1012_98bb, 5); calld(0x1012_0d94, -0x8b2c);            /* call 0x10120d94 */
            ii(0x1012_98c0, 7); mov(memb_a32[ds, 0x101c_609e], 0);      /* mov byte [0x101c609e], 0x0 */
            ii(0x1012_98c7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_98c9, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_98ce, 6); inc(memb_a32[ds, eax + 0x101c_59dc]);   /* inc byte [eax+0x101c59dc] */
            ii(0x1012_98d4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_98d6, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_98db, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_98dd, 6); mov(bl, memb_a32[ds, eax + 0x101c_59dc]); /* mov bl, [eax+0x101c59dc] */
            ii(0x1012_98e3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_98e5, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_98ea, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_98ed, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
            ii(0x1012_98f2, 5); calld(0x1012_8897, -0x1060);            /* call 0x10128897 */
            ii(0x1012_98f7, 5); calld(0x1014_82f4, 0x1_e9f8);           /* call 0x101482f4 */
            ii(0x1012_98fc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_98ff, 5); calld(0x1014_82f4, 0x1_e9f0);           /* call 0x101482f4 */
            ii(0x1012_9904, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_9907, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
        l_0x1012_990b:
            ii(0x1012_990b, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1012_990f, 2); if(jzd(0x1012_991a, 0x9)) goto l_0x1012_991a; /* jz 0x1012991a */
            ii(0x1012_9911, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_9918, 2); if(jnzd(0x1012_991f, 0x5)) goto l_0x1012_991f; /* jnz 0x1012991f */
        l_0x1012_991a:
            ii(0x1012_991a, 5); jmpd(0x1012_99e6, 0xc7); goto l_0x1012_99e6; /* jmp 0x101299e6 */
        l_0x1012_991f:
            ii(0x1012_991f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_9924, 5); calld(0x1012_8835, -0x10f4);            /* call 0x10128835 */
            ii(0x1012_9929, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_992c, 5); calld(0x1014_85ad, 0x1_ec7c);           /* call 0x101485ad */
            ii(0x1012_9931, 5); cmp(eax, 0xbb8);                        /* cmp eax, 0xbb8 */
            ii(0x1012_9936, 2); if(jbed(0x1012_9963, 0x2b)) goto l_0x1012_9963; /* jbe 0x10129963 */
            ii(0x1012_9938, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_993a, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_993f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_9941, 6); mov(bl, memb_a32[ds, eax + 0x101c_59dc]); /* mov bl, [eax+0x101c59dc] */
            ii(0x1012_9947, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9949, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_994e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_9951, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
            ii(0x1012_9956, 5); calld(0x1012_8897, -0x10c4);            /* call 0x10128897 */
            ii(0x1012_995b, 5); calld(0x1014_82f4, 0x1_e994);           /* call 0x101482f4 */
            ii(0x1012_9960, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1012_9963:
            ii(0x1012_9963, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1012_9967, 7); mov(memd_a32[ss, ebp - 0x10], 0x4);     /* mov dword [ebp-0x10], 0x4 */
        l_0x1012_996e:
            ii(0x1012_996e, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x1012_9971, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1012_9976, 2); if(jzd(0x1012_99d3, 0x5b)) goto l_0x1012_99d3; /* jz 0x101299d3 */
            ii(0x1012_9978, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_997c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_9982, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_9988, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_998d, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_9990, 2); if(jnzd(0x1012_99d1, 0x3f)) goto l_0x1012_99d1; /* jnz 0x101299d1 */
            ii(0x1012_9992, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1012_9996, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9998, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_999d, 6); mov(dl, memb_a32[ds, edx + 0x101c_59dc]); /* mov dl, [edx+0x101c59dc] */
            ii(0x1012_99a3, 6); cmp(dl, memb_a32[ds, eax + 0x101c_59dc]); /* cmp dl, [eax+0x101c59dc] */
            ii(0x1012_99a9, 2); if(jzd(0x1012_99d1, 0x26)) goto l_0x1012_99d1; /* jz 0x101299d1 */
            ii(0x1012_99ab, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1012_99af, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_99b2, 5); calld(0x1014_85ad, 0x1_ebf6);           /* call 0x101485ad */
            ii(0x1012_99b7, 5); cmp(eax, 0x7530);                       /* cmp eax, 0x7530 */
            ii(0x1012_99bc, 2); if(jbed(0x1012_99d1, 0x13)) goto l_0x1012_99d1; /* jbe 0x101299d1 */
            ii(0x1012_99be, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1012_99c3, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_99c8, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_99cc, 5); calld(0x1012_748f, -0x2542);            /* call 0x1012748f */
        l_0x1012_99d1:
            ii(0x1012_99d1, 2); jmpd(0x1012_996e, -0x65); goto l_0x1012_996e; /* jmp 0x1012996e */
        l_0x1012_99d3:
            ii(0x1012_99d3, 5); calld(/* sys */ 0x1016_b208, 0x4_1830); /* call 0x1016b208 */
            ii(0x1012_99d8, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1012_99db, 2); if(jnzd(0x1012_99e1, 0x4)) goto l_0x1012_99e1; /* jnz 0x101299e1 */
            ii(0x1012_99dd, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
        l_0x1012_99e1:
            ii(0x1012_99e1, 5); jmpd(0x1012_990b, -0xdb); goto l_0x1012_990b; /* jmp 0x1012990b */
        l_0x1012_99e6:
            ii(0x1012_99e6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_99e8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_99e9, 1); popd(edi);                              /* pop edi */
            ii(0x1012_99ea, 1); popd(esi);                              /* pop esi */
            ii(0x1012_99eb, 1); popd(edx);                              /* pop edx */
            ii(0x1012_99ec, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_99ed, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_99ee, 1); retd();                                 /* ret */
        }
    }
}
