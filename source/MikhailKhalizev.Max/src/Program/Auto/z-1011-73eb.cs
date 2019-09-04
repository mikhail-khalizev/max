using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_73eb-a4495869")]
        public void Method_1011_73eb()
        {
            ii(0x1011_73eb, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_73f0, 5); call(Definitions.sys_check_available_stack_size, 0x4_e95d); /* call 0x10165d52 */
            ii(0x1011_73f5, 1); push(ebx);                              /* push ebx */
            ii(0x1011_73f6, 1); push(ecx);                              /* push ecx */
            ii(0x1011_73f7, 1); push(edx);                              /* push edx */
            ii(0x1011_73f8, 1); push(esi);                              /* push esi */
            ii(0x1011_73f9, 1); push(edi);                              /* push edi */
            ii(0x1011_73fa, 1); push(ebp);                              /* push ebp */
            ii(0x1011_73fb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_73fd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_7403, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_7406, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_7409, 4); mov(memb[ds, eax + 49], 0);             /* mov byte [eax+0x31], 0x0 */
            ii(0x1011_740d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_7410, 4); mov(memb[ds, eax + 50], 0);             /* mov byte [eax+0x32], 0x0 */
            ii(0x1011_7414, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_7417, 4); mov(memb[ds, eax + 59], 0);             /* mov byte [eax+0x3b], 0x0 */
        l_0x1011_741b:
            ii(0x1011_741b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_741e, 4); cmp(memb[ds, eax + 49], 0);             /* cmp byte [eax+0x31], 0x0 */
            ii(0x1011_7422, 2); if(jnz(0x1011_742d, 9)) goto l_0x1011_742d; /* jnz 0x1011742d */
            ii(0x1011_7424, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_7427, 4); cmp(memb[ds, eax + 50], 0);             /* cmp byte [eax+0x32], 0x0 */
            ii(0x1011_742b, 2); if(jz(0x1011_742f, 2)) goto l_0x1011_742f; /* jz 0x1011742f */
        l_0x1011_742d:
            ii(0x1011_742d, 2); jmp(0x1011_7438, 9); goto l_0x1011_7438; /* jmp 0x10117438 */
        l_0x1011_742f:
            ii(0x1011_742f, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_7436, 2); if(jnz(0x1011_743d, 5)) goto l_0x1011_743d; /* jnz 0x1011743d */
        l_0x1011_7438:
            ii(0x1011_7438, 5); jmp(0x1011_74db, 0x9e); goto l_0x1011_74db; /* jmp 0x101174db */
        l_0x1011_743d:
            ii(0x1011_743d, 5); call(0x1012_8626, 0x1_11e4);            /* call 0x10128626 */
            ii(0x1011_7442, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_7444, 2); if(jz(0x1011_744f, 9)) goto l_0x1011_744f; /* jz 0x1011744f */
            ii(0x1011_7446, 7); mov(memd[ss, ebp - 12], 0xd);           /* mov dword [ebp-0xc], 0xd */
            ii(0x1011_744d, 2); jmp(0x1011_7457, 8); goto l_0x1011_7457; /* jmp 0x10117457 */
        l_0x1011_744f:
            ii(0x1011_744f, 5); call(/* sys */ 0x1016_b208, 0x5_3db4);  /* call 0x1016b208 */
            ii(0x1011_7454, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x1011_7457:
            ii(0x1011_7457, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_745b, 2); if(jle(0x1011_7466, 9)) goto l_0x1011_7466; /* jle 0x10117466 */
            ii(0x1011_745d, 7); cmp(memd[ss, ebp - 12], 0x7000);        /* cmp dword [ebp-0xc], 0x7000 */
            ii(0x1011_7464, 2); if(jl(0x1011_7468, 2)) goto l_0x1011_7468; /* jl 0x10117468 */
        l_0x1011_7466:
            ii(0x1011_7466, 2); jmp(0x1011_746f, 7); goto l_0x1011_746f; /* jmp 0x1011746f */
        l_0x1011_7468:
            ii(0x1011_7468, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_746b, 4); mov(memb[ds, eax + 59], 0);             /* mov byte [eax+0x3b], 0x0 */
        l_0x1011_746f:
            ii(0x1011_746f, 4); cmp(memd[ss, ebp - 12], 0xd);           /* cmp dword [ebp-0xc], 0xd */
            ii(0x1011_7473, 2); if(jnz(0x1011_7494, 0x1f)) goto l_0x1011_7494; /* jnz 0x10117494 */
            ii(0x1011_7475, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_7477, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_7479, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1011_747e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_7481, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1011_7486, 5); call(0x1012_8897, 0x1_140c);            /* call 0x10128897 */
            ii(0x1011_748b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_748e, 4); mov(memb[ds, eax + 49], 1);             /* mov byte [eax+0x31], 0x1 */
            ii(0x1011_7492, 2); jmp(0x1011_74a1, 0xd); goto l_0x1011_74a1; /* jmp 0x101174a1 */
        l_0x1011_7494:
            ii(0x1011_7494, 4); cmp(memd[ss, ebp - 12], 0x1b);          /* cmp dword [ebp-0xc], 0x1b */
            ii(0x1011_7498, 2); if(jnz(0x1011_74a1, 7)) goto l_0x1011_74a1; /* jnz 0x101174a1 */
            ii(0x1011_749a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_749d, 4); mov(memb[ds, eax + 50], 1);             /* mov byte [eax+0x32], 0x1 */
        l_0x1011_74a1:
            ii(0x1011_74a1, 7); add(memd[ss, ebp - 12], 0xffff_9000);   /* add dword [ebp-0xc], 0xffff9000 */
            ii(0x1011_74a8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_74ab, 4); cmp(memb[ds, eax + 59], 0);             /* cmp byte [eax+0x3b], 0x0 */
            ii(0x1011_74af, 2); if(jnz(0x1011_74d6, 0x25)) goto l_0x1011_74d6; /* jnz 0x101174d6 */
            ii(0x1011_74b1, 4); cmp(memd[ss, ebp - 12], 0xd);           /* cmp dword [ebp-0xc], 0xd */
            ii(0x1011_74b5, 2); if(jnz(0x1011_74c4, 0xd)) goto l_0x1011_74c4; /* jnz 0x101174c4 */
            ii(0x1011_74b7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_74ba, 3); mov(eax, memd[ds, eax + 51]);           /* mov eax, [eax+0x33] */
            ii(0x1011_74bd, 5); call(0x100c_fbbe, -0x4_7904);           /* call 0x100cfbbe */
            ii(0x1011_74c2, 2); jmp(0x1011_74cf, 0xb); goto l_0x1011_74cf; /* jmp 0x101174cf */
        l_0x1011_74c4:
            ii(0x1011_74c4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_74c7, 3); mov(eax, memd[ds, eax + 55]);           /* mov eax, [eax+0x37] */
            ii(0x1011_74ca, 5); call(0x100c_fbbe, -0x4_7911);           /* call 0x100cfbbe */
        l_0x1011_74cf:
            ii(0x1011_74cf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_74d2, 4); mov(memb[ds, eax + 59], 1);             /* mov byte [eax+0x3b], 0x1 */
        l_0x1011_74d6:
            ii(0x1011_74d6, 5); jmp(0x1011_741b, -0xc0); goto l_0x1011_741b; /* jmp 0x1011741b */
        l_0x1011_74db:
            ii(0x1011_74db, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_74dd, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_74e0, 3); mov(al, memb[ds, edx + 49]);            /* mov al, [edx+0x31] */
            ii(0x1011_74e3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_74e6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_74e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_74eb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_74ec, 1); pop(edi);                               /* pop edi */
            ii(0x1011_74ed, 1); pop(esi);                               /* pop esi */
            ii(0x1011_74ee, 1); pop(edx);                               /* pop edx */
            ii(0x1011_74ef, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_74f0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_74f1, 1); ret();                                  /* ret */
        }
    }
}
